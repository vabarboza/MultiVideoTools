
# MultiVideoConverter

O **MultiVideoConverter** é uma aplicação para download e conversão de vídeos e músicas diretamente do YouTube. Ele permite que você baixe vídeos, extraia áudio de vídeos, e converta arquivos de vídeo em diferentes formatos, com opções para ajustar a qualidade, velocidade de conversão e mais.

## Funcionalidades

### Download de Vídeos
- Adicione URLs de vídeos do YouTube para download.
- Baixe vídeos em sequência e converta para o formato `.mkv`.
- Mescle automaticamente os streams de vídeo e áudio em um único arquivo.
  
### Download de Músicas
- Extraia o áudio de vídeos do YouTube e baixe no formato `.mp3`.
- Baixe múltiplos arquivos de música em sequência.

### Conversão de Vídeos
- Converta arquivos de vídeo para os formatos `.mp4`, `.mkv`, `.avi`, ou `.hevc`.
- Ajuste a qualidade da conversão (bitrate) e a velocidade de processamento.
- Escolha entre usar a CPU ou uma placa de vídeo (Nvidia ou AMD) para aceleração de hardware durante a conversão.
- Suporte para legendas embutidas em vídeos.

## Tecnologias Utilizadas

- [YoutubeExplode](https://github.com/Tyrrrz/YoutubeExplode): Biblioteca usada para buscar e fazer download de vídeos e áudios do YouTube.
- [Xabe.FFmpeg](https://github.com/tomaszzmuda/Xabe.FFmpeg): Biblioteca usada para conversão e manipulação de arquivos de vídeo e áudio.
- [FFmpeg](https://ffmpeg.org/): Utilitário usado para processar e converter arquivos multimídia.

## Como Usar

1. **Download de Vídeos:**
   - Insira a URL de um vídeo do YouTube no campo correspondente.
   - Selecione a pasta de saída para salvar os vídeos baixados.
   - Clique em "Baixar Vídeos" para iniciar o processo.

2. **Download de Músicas:**
   - Insira a URL de um vídeo do YouTube para extrair o áudio.
   - Selecione a pasta de saída para salvar as músicas.
   - Clique em "Baixar Músicas" para iniciar o processo.

3. **Conversão de Vídeos:**
   - Selecione a pasta com os arquivos de vídeo que deseja converter.
   - Selecione o formato de saída, qualidade e dispositivo para conversão (CPU, Nvidia, AMD).
   - Defina a pasta de saída e clique em "Converter".

## Instalação

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/MultiVideoConverter.git
   ```

2. Baixe e instale o [FFmpeg](https://ffmpeg.org/download.html) ou deixe que o aplicativo faça o download automático durante o uso.

3. Compile o projeto no Visual Studio.

## Requisitos

- .NET Framework 4.8 ou superior
- FFmpeg
- YoutubeExplode

## Licença

Este projeto é licenciado sob os termos da [MIT License](LICENSE).
