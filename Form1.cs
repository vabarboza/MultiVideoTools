using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg.Downloader;
using Xabe.FFmpeg;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using AngleSharp.Dom;
using SharpConfig;

namespace MultiVideoTools
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        List<string> listVideo = new List<string>();
        List<string> listMusic = new List<string>();

        public FormMain()
        {
            InitializeComponent();
        }

        #region Video download

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            string videoUrl = tbVideoLink.Text;
            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Por favor, insira a URL do vídeo do YouTube.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddVideoToListBox(videoUrl);
        }

        private async void AddVideoToListBox(string videoUrl)
        {
            var youtube = new YoutubeClient();

            labelStatusVideo.Text = "Obtendo ID do vídeo.";
            var video = await youtube.Videos.GetAsync(videoUrl);
            labelStatusVideo.Text = "Video adicionado.";
            var videoTittle = video.Title;

            listBoxLinksVideos.Items.Add(videoTittle);
            listVideo.Add(videoUrl);
            tbVideoLink.Text = "";
        }

        private void btnCleanVideos_Click(object sender, EventArgs e)
        {
            listBoxLinksVideos.Items.Clear();
        }

        private void btnLocationVideo_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    tbLocationVideo.Text = selectedFolder;
                }
            }
        }

        private async void btnDownloadVideos_Click(object sender, EventArgs e)
        {
            if (listBoxLinksVideos.Items.Count == 0)
            {
                MessageBox.Show("Não há links para baixar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbLocationVideo.Text))
            {
                MessageBox.Show("Por favor, selecione uma pasta de saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "downloads");
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            labelStatusVideo.Text = "Iniciando processo de download em sequência...";
            try
            {
                List<string> videoUrls = listBoxLinksVideos.Items.Cast<string>().ToList();
                await DownloadVideosFromListBox(listVideo, videoUrls, tbLocationVideo.Text);
                labelStatusVideo.Text = "Downloads em sequência concluídos com sucesso.";
            }
            catch (Exception ex)
            {
                labelStatusVideo.Text = $"Ocorreu um erro: {ex.Message}";
            }
        }

        private async Task DownloadVideosFromListBox(List<string> videoUrls, List<string> videoUrlsBox, string outputDirectory)
        {
            foreach (var videoUrl in videoUrls)
            {
                try
                {
                    await DownloadAndConvertVideo(videoUrl, outputDirectory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao baixar o vídeo {videoUrl}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async Task DownloadAndConvertVideo(string videoUrl, string outputDirectory)
        {
            if (string.IsNullOrEmpty(outputDirectory))
            {
                MessageBox.Show("Por favor, selecione uma pasta de saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var youtube = new YoutubeClient();

            labelStatusVideo.Text = "Obtendo ID do vídeo.";
            var video = await youtube.Videos.GetAsync(videoUrl);
            var videoId = video.Id;

            labelStatusVideo.Text = "Obtendo informações do vídeo.";
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

            var videoStream = streamManifest.GetVideoStreams().GetWithHighestVideoQuality();

            var audioStream = streamManifest.GetAudioStreams().GetWithHighestBitrate();

            var videoTitle = Regex.Replace(video.Title, @"[<>:""/\\|?*]", string.Empty);

            var tempPath = Path.Combine(Directory.GetCurrentDirectory(), "temp");

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            labelStatusVideo.Text = "Definindo caminho dos arquivos de vídeo e áudio.";
            var videoFilePath = Path.Combine(tempPath, $"{videoTitle}_video.mp4");
            var audioFilePath = Path.Combine(tempPath, $"{videoTitle}_audio.mp3");

            pbDownloadVideo.Maximum = 100;
            pbDownloadVideo.Value = 0;

            var progressHandler = new Progress<double>(progress =>
            {
                pbDownloadVideo.Value = (int)(progress * 100);
            });

            labelStatusVideo.Text = "Iniciando download do vídeo.";
            await youtube.Videos.Streams.DownloadAsync(videoStream, videoFilePath, progressHandler);

            labelStatusVideo.Text = "Iniciando download do áudio.";
            await youtube.Videos.Streams.DownloadAsync(audioStream, audioFilePath, progressHandler);

            var finalFilePath = Path.Combine(outputDirectory, $"{videoTitle}.mkv");

            var ffmpegPath = Path.Combine(Directory.GetCurrentDirectory(), "ffmpeg");

            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official, ffmpegPath);
            FFmpeg.SetExecutablesPath(ffmpegPath);

            var videoInfo = await FFmpeg.GetMediaInfo(videoFilePath);
            var audioInfo = await FFmpeg.GetMediaInfo(audioFilePath);

            var videoStreamInfo = videoInfo.VideoStreams.FirstOrDefault();
            var audioStreamInfo = audioInfo.AudioStreams.FirstOrDefault();

            pbDownloadVideo.Value = 0;

            labelStatusVideo.Text = "Iniciando mesclagem de audio e video.";
            var conversion = FFmpeg.Conversions.New()
                .AddStream(videoStreamInfo)
                .AddStream(audioStreamInfo)
                .SetOutput(finalFilePath)
                .AddParameter("-preset ultrafast");

            conversion.OnProgress += (sender, args) =>
            {
                pbDownloadVideo.Invoke(new Action(() =>
                {
                    pbDownloadVideo.Value = (int)args.Percent;
                }));
            };

            await conversion.Start();

            pbDownloadVideo.Value = 100;
            listBoxLinksVideos.Items.Clear();
            labelStatusVideo.Text = "Download e conversão concluídos.";
        }

        #endregion

        #region Music Download

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            string videoUrl = tbMusicLink.Text;
            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Por favor, insira a URL do vídeo do YouTube.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddMusicToListBox(videoUrl);
        }


        private async void AddMusicToListBox(string videoUrl)
        {
            var youtube = new YoutubeClient();

            labelStatusMusic.Text = "Obtendo ID do vídeo.";
            var audio = await youtube.Videos.GetAsync(videoUrl);
            labelStatusMusic.Text = "Video adicionado.";
            var audioTittle = audio.Title;

            listBoxLinksMusic.Items.Add(audioTittle);
            listMusic.Add(videoUrl);
            tbMusicLink.Text = "";
        }

        private void btnCleanMusic_Click(object sender, EventArgs e)
        {
            listBoxLinksMusic.Items.Clear();
        }

        private void btnLocationMusic_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    tbLocationMusic.Text = selectedFolder;
                }
            }
        }

        private async void btnDownloadMusic_Click(object sender, EventArgs e)
        {
            if (listBoxLinksMusic.Items.Count == 0)
            {
                MessageBox.Show("Não há links para baixar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbLocationMusic.Text))
            {
                MessageBox.Show("Por favor, selecione uma pasta de saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "downloads");
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            labelStatusMusic.Text = "Iniciando processo de download em sequência...";
            try
            {
                List<string> videoUrls = listBoxLinksMusic.Items.Cast<string>().ToList();
                await DownloadMusicFromListBox(listMusic, tbLocationMusic.Text);
                listBoxLinksMusic.Items.Clear();
                labelStatusMusic.Text = "Downloads em sequência concluídos com sucesso.";
            }
            catch (Exception ex)
            {
                labelStatusMusic.Text = $"Ocorreu um erro: {ex.Message}";
            }
        }


        private async Task DownloadMusicFromListBox(List<string> videoUrls, string outputDirectory)
        {
            foreach (var videoUrl in videoUrls)
            {
                try
                {
                    await DownloadAndConvertMusic(videoUrl, outputDirectory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao baixar a musica {videoUrl}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task DownloadAndConvertMusic(string videoUrl, string outputDirectory)
        {
            if (string.IsNullOrEmpty(outputDirectory))
            {
                MessageBox.Show("Por favor, selecione uma pasta de saída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var youtube = new YoutubeClient();

            // Exibir status de obtenção do ID do vídeo
            labelStatusMusic.Text = "Obtendo ID da musica.";
            var video = await youtube.Videos.GetAsync(videoUrl);
            var videoId = video.Id;

            // Exibir status de obtenção das informações do vídeo
            labelStatusMusic.Text = "Obtendo informações da musica.";
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

            // Obter o stream de áudio com a maior qualidade
            var audioStream = streamManifest.GetAudioStreams().GetWithHighestBitrate();

            // Limpar o título do vídeo para gerar um nome de arquivo válido
            var videoTitle = Regex.Replace(video.Title, @"[<>:""/\\|?*]", string.Empty);

            // Caminho final do arquivo de áudio
            var finalFilePath = Path.Combine(outputDirectory, $"{videoTitle}.mp3");

            // Definir valor máximo da ProgressBar
            pbDownloadMusic.Maximum = 100;
            pbDownloadMusic.Value = 0;

            // Configurar o manipulador de progresso
            var progressHandler = new Progress<double>(progress =>
            {
                // Atualiza a ProgressBar com base no progresso do download
                pbDownloadMusic.Invoke(new Action(() =>
                {
                    pbDownloadMusic.Value = (int)(progress * 100);
                }));
            });

            // Exibir status de download do áudio
            labelStatusMusic.Text = "Iniciando download do áudio.";

            // Baixar o stream de áudio e salvar como arquivo MP3
            await youtube.Videos.Streams.DownloadAsync(audioStream, finalFilePath, progressHandler);

            // Atualizar ProgressBar e status após conclusão do download
            pbDownloadMusic.Value = 100;
            labelStatusMusic.Text = "Download concluído com sucesso.";
        }

        #endregion

        #region Video Converter

        private void btnAddConvert_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbConvertLocal.Text = dialog.SelectedPath;
                    lbConvertFiles.Items.Clear();

                    string[] videoExtensions = { ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".flv", ".webm", ".ts" };

                    string[] inputFiles = Directory.GetFiles(dialog.SelectedPath, "*.*")
                                                   .Where(f => videoExtensions.Contains(Path.GetExtension(f).ToLower()))
                                                   .OrderBy(f => Path.GetFileName(f))
                                                   .ToArray();

                    foreach (string file in inputFiles)
                    {
                        lbConvertFiles.Items.Add(file);
                    }

                }
            }
        }

        private void btnSelectExit_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    tbConvertExit.Text = selectedFolder;
                }
            }
        }

        private async void metroButton11_Click(object sender, EventArgs e)
        {
            string outputFolder = tbConvertExit.Text;

            if (cbFormat.SelectedItem == null)
            {
                MessageBox.Show("Selecione um formato", "Erro");
                return;
            }

            if (cbSpeed.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma velocidade", "Erro");
                return;
            }

            if (cbBits.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma taxa de bits", "Erro");
                return;
            }

            if (cbCards.SelectedItem == null)
            {
                MessageBox.Show("Selecione um dispositivo de conversão", "Erro");
                return;
            }

            cbSpeed.Enabled = false;
            cbBits.Enabled = false;
            cbCards.Enabled = false;
            cbFormat.Enabled = false;
            tbConvertLocal.Enabled = false;
            tbConvertExit.Enabled = false;

            if (lbConvertFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo selecionado.");
                return;
            }

            if (!Directory.Exists(outputFolder))
            {
                MessageBox.Show("Pasta de saída não encontrada. Criando pasta...");
                Directory.CreateDirectory(outputFolder);
            }

            List<string> filesToConvert = lbConvertFiles.Items.Cast<string>().ToList();

            foreach (string inputFile in filesToConvert)
            {
                string outputFile = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(inputFile) + ".mp4");
                await Convert(inputFile, outputFile);

                lbConvertFiles.Items.Remove(inputFile);
            }

            if (cbPower.Checked)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                MessageBox.Show("Conversão concluída.");
            }

            cbSpeed.Enabled = true;
            cbBits.Enabled = true;
            cbCards.Enabled = true;
            cbFormat.Enabled = true;
            tbConvertLocal.Enabled = true;
            tbConvertExit.Enabled = true;
        }

        private async Task Convert(string inputPath, string outputPath)
        {
            try
            {
                string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg");
                if (string.IsNullOrEmpty(ffmpegPath))
                {
                    await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official, ffmpegPath);
                }

                FFmpeg.SetExecutablesPath(ffmpegPath);

                var mediaInfo = await FFmpeg.GetMediaInfo(inputPath);
                var videoStream = mediaInfo.VideoStreams.FirstOrDefault();
                var audioStreamList = mediaInfo.AudioStreams.ToList();
                var audioStream = audioStreamList.FirstOrDefault(x => x.Language.Contains("por") || x.Language.Contains("Brazilian")) ?? audioStreamList.FirstOrDefault();

                var legendList = mediaInfo.SubtitleStreams.ToList();

                var legend = legendList.FirstOrDefault(x => (x.Language.Contains("por") || x.Language.Contains("Brazilian (Forced)")) && x.Title.Contains("Forced")) ?? legendList.FirstOrDefault();

                if (videoStream == null || audioStream == null)
                {
                    MessageBox.Show($"Arquivo de entrada {inputPath} não possui streams de vídeo ou áudio válidas.");
                    return;
                }

                string selectedCard = cbCards.SelectedItem?.ToString();
                string selectedBits = cbBits.SelectedItem?.ToString();
                string selectedSpeed = cbSpeed.SelectedItem?.ToString();
                string selectedFormat = cbFormat.SelectedItem?.ToString();

                switch (selectedBits)
                {
                    case "Ultra":
                        selectedBits = "6000k";
                        break;
                    case "Alta":
                        selectedBits = "5000k";
                        break;
                    case "Media":
                        selectedBits = "4000k";
                        break;
                    case "Baixa":
                        selectedBits = "3500k";
                        break;
                    case "Minima":
                        selectedBits = "2000k";
                        break;
                }

                switch (selectedSpeed)
                {
                    case "Super Rapido":
                        selectedSpeed = "superfast";
                        break;
                    case "Rapido":
                        selectedSpeed = "faster";
                        break;
                    case "Medio":
                        selectedSpeed = "medium";
                        break;
                    case "Lento":
                        selectedSpeed = "slow";
                        break;
                    case "Super Lento":
                        selectedSpeed = "slower";
                        break;
                }

                Format videoFormat = new Format();

                switch (selectedFormat)
                {
                    case "MP4":
                        videoFormat = Format.mp4;
                        break;
                    case "MKV":
                        videoFormat = Format.matroska;
                        break;
                    case "AVI":
                        videoFormat = Format.avi;
                        break;
                    case "HEVC":
                        videoFormat = Format.hevc;
                        break;
                }


                IConversion conversion = FFmpeg.Conversions.New()
                    .AddStream(videoStream)
                    .AddStream(audioStream);

                if (legend != null)
                {
                    conversion.AddStream(legend);
                }

                switch (selectedCard)
                {
                    case "Processador":
                        conversion
                            .AddParameter("-c:v libx265")
                            .AddParameter($"-preset {selectedSpeed}")
                            .AddParameter($"-b:v {selectedBits}");
                        break;
                    case "Placa de video Nvidia":
                        conversion
                            .AddParameter("-c:v hevc_nvenc")
                            .AddParameter($"-preset {selectedSpeed}")
                            .AddParameter($"-b:v {selectedBits}");
                        break;
                    case "Placa de video AMD":
                        conversion
                            .AddParameter("-c:v hevc_amf")
                            .AddParameter($"-preset {selectedSpeed}")
                            .AddParameter($"-b:v {selectedBits}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                conversion
                    .SetOutput(outputPath)
                    .SetOverwriteOutput(true)
                    .SetOutputFormat(videoFormat);

                conversion.OnProgress += (sender, args) =>
                {
                    Invoke(new Action(() =>
                    {
                        pbConvert.Value = (int)args.Percent;
                        lbConvert.Text = $"Convertendo: {Path.GetFileNameWithoutExtension(inputPath).Substring(0, Math.Min(70, Path.GetFileNameWithoutExtension(inputPath).Length))}";
                        lbPercent.Text = $"{args.Percent}%";
                    }));
                };

                await conversion.Start();

                Invoke(new Action(() =>
                {
                    lbConvert.Text = $"Conversão concluída: {Path.GetFileName(inputPath)}";
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao converter o arquivo {inputPath}: {ex.Message}");
                Invoke(new Action(() =>
                {
                    lbConvert.Text = $"Erro: {ex.Message}";
                }));
            }
        }

        #endregion

        #region INI Configs

        private void FormMain_Load(object sender, EventArgs e)
        {
            string configFilePath = "config.ini";

            if (File.Exists(configFilePath))
            {
                Configuration config = Configuration.LoadFromFile("config.ini");
                Section sectionVideo = config["Video"];
                Section sectionMusic = config["Music"];
                Section sectionConvert = config["Convert"];

                string outputDirectoryVideo = sectionVideo["directory"].GetValue<string>();
                string outputDirectoryMusic = sectionMusic["directory"].GetValue<string>();
                string bits = sectionConvert["bits"].GetValue<string>();
                string speed = sectionConvert["speed"].GetValue<string>();
                string format = sectionConvert["format"].GetValue<string>();
                string card = sectionConvert["card"].GetValue<string>();

                tbLocationVideo.Text = outputDirectoryVideo;
                tbLocationMusic.Text = outputDirectoryMusic;

                cbBits.Text = bits;
                cbSpeed.Text = speed;
                cbFormat.Text = format;
                cbCards.Text = card;

            }
            else
            {
                CreateConfig();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var myConfig = new Configuration();
            myConfig["Video"]["directory"].StringValue = tbLocationVideo.Text;
            myConfig["Music"]["directory"].StringValue = tbLocationMusic.Text;
            myConfig["Convert"]["bits"].StringValue = cbBits.Text;
            myConfig["Convert"]["speed"].StringValue = cbSpeed.Text;
            myConfig["Convert"]["format"].StringValue = cbFormat.Text;
            myConfig["Convert"]["card"].StringValue = cbCards.Text;

            myConfig.SaveToFile("config.ini");
        }

        private void CreateConfig()
        {
            var myConfig = new Configuration();
            //Video Download
            myConfig["Video"]["directory"].StringValue = "";

            //Music DOwnload
            myConfig["Music"]["directory"].StringValue = "";

            //Convert
            myConfig["Convert"]["bits"].StringValue = "";
            myConfig["Convert"]["speed"].StringValue = "";
            myConfig["Convert"]["format"].StringValue = "";
            myConfig["Convert"]["card"].StringValue = "";


            //Salva arquivo de configuração
            myConfig.SaveToFile("config.ini");
        }

        #endregion
    }
}
