namespace MultiVideoTools
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelStatusVideo = new MetroFramework.Controls.MetroLabel();
            this.pbDownloadVideo = new MetroFramework.Controls.MetroProgressBar();
            this.btnLocationVideo = new MetroFramework.Controls.MetroButton();
            this.tbLocationVideo = new MetroFramework.Controls.MetroTextBox();
            this.btnCleanVideos = new MetroFramework.Controls.MetroButton();
            this.btnDownloadVideos = new MetroFramework.Controls.MetroButton();
            this.listBoxLinksVideos = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddVideo = new MetroFramework.Controls.MetroButton();
            this.tbVideoLink = new MetroFramework.Controls.MetroTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelStatusMusic = new MetroFramework.Controls.MetroLabel();
            this.pbDownloadMusic = new MetroFramework.Controls.MetroProgressBar();
            this.btnLocationMusic = new MetroFramework.Controls.MetroButton();
            this.btnCleanMusic = new MetroFramework.Controls.MetroButton();
            this.btnDownloadMusic = new MetroFramework.Controls.MetroButton();
            this.tbLocationMusic = new MetroFramework.Controls.MetroTextBox();
            this.listBoxLinksMusic = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnAddMusic = new MetroFramework.Controls.MetroButton();
            this.tbMusicLink = new MetroFramework.Controls.MetroTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbConvert = new MetroFramework.Controls.MetroLabel();
            this.pbConvert = new MetroFramework.Controls.MetroProgressBar();
            this.cbPower = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbCards = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbFormat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbSpeed = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbBits = new MetroFramework.Controls.MetroComboBox();
            this.lbConvertFiles = new System.Windows.Forms.ListBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnSelectExit = new MetroFramework.Controls.MetroButton();
            this.tbConvertExit = new MetroFramework.Controls.MetroTextBox();
            this.btnAddConvert = new MetroFramework.Controls.MetroButton();
            this.tbConvertLocal = new MetroFramework.Controls.MetroTextBox();
            this.lbPercent = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            resources.ApplyResources(this.metroTabControl1, "metroTabControl1");
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.labelStatusVideo);
            this.tabPage1.Controls.Add(this.pbDownloadVideo);
            this.tabPage1.Controls.Add(this.btnLocationVideo);
            this.tabPage1.Controls.Add(this.tbLocationVideo);
            this.tabPage1.Controls.Add(this.btnCleanVideos);
            this.tabPage1.Controls.Add(this.btnDownloadVideos);
            this.tabPage1.Controls.Add(this.listBoxLinksVideos);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.btnAddVideo);
            this.tabPage1.Controls.Add(this.tbVideoLink);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelStatusVideo
            // 
            resources.ApplyResources(this.labelStatusVideo, "labelStatusVideo");
            this.labelStatusVideo.Name = "labelStatusVideo";
            // 
            // pbDownloadVideo
            // 
            resources.ApplyResources(this.pbDownloadVideo, "pbDownloadVideo");
            this.pbDownloadVideo.Name = "pbDownloadVideo";
            this.pbDownloadVideo.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // btnLocationVideo
            // 
            this.btnLocationVideo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLocationVideo.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLocationVideo, "btnLocationVideo");
            this.btnLocationVideo.Name = "btnLocationVideo";
            this.btnLocationVideo.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLocationVideo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLocationVideo.UseCustomBackColor = true;
            this.btnLocationVideo.UseCustomForeColor = true;
            this.btnLocationVideo.UseSelectable = true;
            this.btnLocationVideo.Click += new System.EventHandler(this.btnLocationVideo_Click);
            // 
            // tbLocationVideo
            // 
            // 
            // 
            // 
            this.tbLocationVideo.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.tbLocationVideo.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.tbLocationVideo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tbLocationVideo.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.tbLocationVideo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.tbLocationVideo.CustomButton.Name = "";
            this.tbLocationVideo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.tbLocationVideo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLocationVideo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.tbLocationVideo.CustomButton.Text = resources.GetString("resource.Text");
            this.tbLocationVideo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLocationVideo.CustomButton.UseSelectable = true;
            this.tbLocationVideo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.tbLocationVideo.DisplayIcon = true;
            this.tbLocationVideo.Icon = global::MultiVideoTools.Properties.Resources.folder__2_;
            this.tbLocationVideo.Lines = new string[0];
            resources.ApplyResources(this.tbLocationVideo, "tbLocationVideo");
            this.tbLocationVideo.MaxLength = 32767;
            this.tbLocationVideo.Name = "tbLocationVideo";
            this.tbLocationVideo.PasswordChar = '\0';
            this.tbLocationVideo.PromptText = "Local de salvamento..";
            this.tbLocationVideo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocationVideo.SelectedText = "";
            this.tbLocationVideo.SelectionLength = 0;
            this.tbLocationVideo.SelectionStart = 0;
            this.tbLocationVideo.ShortcutsEnabled = true;
            this.tbLocationVideo.ShowClearButton = true;
            this.tbLocationVideo.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbLocationVideo.UseSelectable = true;
            this.tbLocationVideo.WaterMark = "Local de salvamento..";
            this.tbLocationVideo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLocationVideo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCleanVideos
            // 
            this.btnCleanVideos.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCleanVideos.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCleanVideos, "btnCleanVideos");
            this.btnCleanVideos.Name = "btnCleanVideos";
            this.btnCleanVideos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCleanVideos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCleanVideos.UseCustomBackColor = true;
            this.btnCleanVideos.UseCustomForeColor = true;
            this.btnCleanVideos.UseSelectable = true;
            this.btnCleanVideos.Click += new System.EventHandler(this.btnCleanVideos_Click);
            // 
            // btnDownloadVideos
            // 
            this.btnDownloadVideos.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDownloadVideos.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnDownloadVideos, "btnDownloadVideos");
            this.btnDownloadVideos.Name = "btnDownloadVideos";
            this.btnDownloadVideos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDownloadVideos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDownloadVideos.UseCustomBackColor = true;
            this.btnDownloadVideos.UseCustomForeColor = true;
            this.btnDownloadVideos.UseSelectable = true;
            this.btnDownloadVideos.Click += new System.EventHandler(this.btnDownloadVideos_Click);
            // 
            // listBoxLinksVideos
            // 
            this.listBoxLinksVideos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLinksVideos.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxLinksVideos, "listBoxLinksVideos");
            this.listBoxLinksVideos.Name = "listBoxLinksVideos";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddVideo.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAddVideo, "btnAddVideo");
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddVideo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddVideo.UseCustomBackColor = true;
            this.btnAddVideo.UseCustomForeColor = true;
            this.btnAddVideo.UseSelectable = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // tbVideoLink
            // 
            // 
            // 
            // 
            this.tbVideoLink.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.tbVideoLink.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.tbVideoLink.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.tbVideoLink.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.tbVideoLink.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.tbVideoLink.CustomButton.Name = "";
            this.tbVideoLink.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.tbVideoLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbVideoLink.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.tbVideoLink.CustomButton.Text = resources.GetString("resource.Text1");
            this.tbVideoLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbVideoLink.CustomButton.UseSelectable = true;
            this.tbVideoLink.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.tbVideoLink.DisplayIcon = true;
            this.tbVideoLink.Icon = global::MultiVideoTools.Properties.Resources.youtube__2_;
            this.tbVideoLink.Lines = new string[0];
            resources.ApplyResources(this.tbVideoLink, "tbVideoLink");
            this.tbVideoLink.MaxLength = 32767;
            this.tbVideoLink.Name = "tbVideoLink";
            this.tbVideoLink.PasswordChar = '\0';
            this.tbVideoLink.PromptText = "Link do video";
            this.tbVideoLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVideoLink.SelectedText = "";
            this.tbVideoLink.SelectionLength = 0;
            this.tbVideoLink.SelectionStart = 0;
            this.tbVideoLink.ShortcutsEnabled = true;
            this.tbVideoLink.ShowClearButton = true;
            this.tbVideoLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbVideoLink.UseSelectable = true;
            this.tbVideoLink.WaterMark = "Link do video";
            this.tbVideoLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbVideoLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.labelStatusMusic);
            this.tabPage2.Controls.Add(this.pbDownloadMusic);
            this.tabPage2.Controls.Add(this.btnLocationMusic);
            this.tabPage2.Controls.Add(this.btnCleanMusic);
            this.tabPage2.Controls.Add(this.btnDownloadMusic);
            this.tabPage2.Controls.Add(this.tbLocationMusic);
            this.tabPage2.Controls.Add(this.listBoxLinksMusic);
            this.tabPage2.Controls.Add(this.metroLabel4);
            this.tabPage2.Controls.Add(this.btnAddMusic);
            this.tabPage2.Controls.Add(this.tbMusicLink);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelStatusMusic
            // 
            resources.ApplyResources(this.labelStatusMusic, "labelStatusMusic");
            this.labelStatusMusic.Name = "labelStatusMusic";
            // 
            // pbDownloadMusic
            // 
            resources.ApplyResources(this.pbDownloadMusic, "pbDownloadMusic");
            this.pbDownloadMusic.Name = "pbDownloadMusic";
            this.pbDownloadMusic.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // btnLocationMusic
            // 
            this.btnLocationMusic.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLocationMusic.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLocationMusic, "btnLocationMusic");
            this.btnLocationMusic.Name = "btnLocationMusic";
            this.btnLocationMusic.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLocationMusic.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLocationMusic.UseCustomBackColor = true;
            this.btnLocationMusic.UseCustomForeColor = true;
            this.btnLocationMusic.UseSelectable = true;
            this.btnLocationMusic.Click += new System.EventHandler(this.btnLocationMusic_Click);
            // 
            // btnCleanMusic
            // 
            this.btnCleanMusic.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCleanMusic.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCleanMusic, "btnCleanMusic");
            this.btnCleanMusic.Name = "btnCleanMusic";
            this.btnCleanMusic.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCleanMusic.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCleanMusic.UseCustomBackColor = true;
            this.btnCleanMusic.UseCustomForeColor = true;
            this.btnCleanMusic.UseSelectable = true;
            this.btnCleanMusic.Click += new System.EventHandler(this.btnCleanMusic_Click);
            // 
            // btnDownloadMusic
            // 
            this.btnDownloadMusic.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDownloadMusic.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnDownloadMusic, "btnDownloadMusic");
            this.btnDownloadMusic.Name = "btnDownloadMusic";
            this.btnDownloadMusic.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDownloadMusic.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDownloadMusic.UseCustomBackColor = true;
            this.btnDownloadMusic.UseCustomForeColor = true;
            this.btnDownloadMusic.UseSelectable = true;
            this.btnDownloadMusic.Click += new System.EventHandler(this.btnDownloadMusic_Click);
            // 
            // tbLocationMusic
            // 
            // 
            // 
            // 
            this.tbLocationMusic.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.tbLocationMusic.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.tbLocationMusic.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.tbLocationMusic.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.tbLocationMusic.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.tbLocationMusic.CustomButton.Name = "";
            this.tbLocationMusic.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.tbLocationMusic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLocationMusic.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.tbLocationMusic.CustomButton.Text = resources.GetString("resource.Text2");
            this.tbLocationMusic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLocationMusic.CustomButton.UseSelectable = true;
            this.tbLocationMusic.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.tbLocationMusic.DisplayIcon = true;
            this.tbLocationMusic.Icon = global::MultiVideoTools.Properties.Resources.folder__2_;
            this.tbLocationMusic.Lines = new string[0];
            resources.ApplyResources(this.tbLocationMusic, "tbLocationMusic");
            this.tbLocationMusic.MaxLength = 32767;
            this.tbLocationMusic.Name = "tbLocationMusic";
            this.tbLocationMusic.PasswordChar = '\0';
            this.tbLocationMusic.PromptText = "Local de salvamento..";
            this.tbLocationMusic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocationMusic.SelectedText = "";
            this.tbLocationMusic.SelectionLength = 0;
            this.tbLocationMusic.SelectionStart = 0;
            this.tbLocationMusic.ShortcutsEnabled = true;
            this.tbLocationMusic.ShowClearButton = true;
            this.tbLocationMusic.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbLocationMusic.UseSelectable = true;
            this.tbLocationMusic.WaterMark = "Local de salvamento..";
            this.tbLocationMusic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLocationMusic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBoxLinksMusic
            // 
            this.listBoxLinksMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLinksMusic.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxLinksMusic, "listBoxLinksMusic");
            this.listBoxLinksMusic.Name = "listBoxLinksMusic";
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.Name = "metroLabel4";
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddMusic.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAddMusic, "btnAddMusic");
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddMusic.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddMusic.UseCustomBackColor = true;
            this.btnAddMusic.UseCustomForeColor = true;
            this.btnAddMusic.UseSelectable = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // tbMusicLink
            // 
            // 
            // 
            // 
            this.tbMusicLink.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3");
            this.tbMusicLink.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName3");
            this.tbMusicLink.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.tbMusicLink.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.tbMusicLink.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.tbMusicLink.CustomButton.Name = "";
            this.tbMusicLink.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.tbMusicLink.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMusicLink.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.tbMusicLink.CustomButton.Text = resources.GetString("resource.Text3");
            this.tbMusicLink.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMusicLink.CustomButton.UseSelectable = true;
            this.tbMusicLink.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.tbMusicLink.DisplayIcon = true;
            this.tbMusicLink.Icon = global::MultiVideoTools.Properties.Resources.youtube__2_;
            this.tbMusicLink.Lines = new string[0];
            resources.ApplyResources(this.tbMusicLink, "tbMusicLink");
            this.tbMusicLink.MaxLength = 32767;
            this.tbMusicLink.Name = "tbMusicLink";
            this.tbMusicLink.PasswordChar = '\0';
            this.tbMusicLink.PromptText = "Link do video";
            this.tbMusicLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMusicLink.SelectedText = "";
            this.tbMusicLink.SelectionLength = 0;
            this.tbMusicLink.SelectionStart = 0;
            this.tbMusicLink.ShortcutsEnabled = true;
            this.tbMusicLink.ShowClearButton = true;
            this.tbMusicLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbMusicLink.UseSelectable = true;
            this.tbMusicLink.WaterMark = "Link do video";
            this.tbMusicLink.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMusicLink.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.lbPercent);
            this.tabPage3.Controls.Add(this.lbConvert);
            this.tabPage3.Controls.Add(this.pbConvert);
            this.tabPage3.Controls.Add(this.cbPower);
            this.tabPage3.Controls.Add(this.metroButton11);
            this.tabPage3.Controls.Add(this.metroLabel9);
            this.tabPage3.Controls.Add(this.cbCards);
            this.tabPage3.Controls.Add(this.metroLabel8);
            this.tabPage3.Controls.Add(this.cbFormat);
            this.tabPage3.Controls.Add(this.metroLabel7);
            this.tabPage3.Controls.Add(this.cbSpeed);
            this.tabPage3.Controls.Add(this.metroLabel6);
            this.tabPage3.Controls.Add(this.cbBits);
            this.tabPage3.Controls.Add(this.lbConvertFiles);
            this.tabPage3.Controls.Add(this.metroLabel5);
            this.tabPage3.Controls.Add(this.btnSelectExit);
            this.tabPage3.Controls.Add(this.tbConvertExit);
            this.tabPage3.Controls.Add(this.btnAddConvert);
            this.tabPage3.Controls.Add(this.tbConvertLocal);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // lbConvert
            // 
            resources.ApplyResources(this.lbConvert, "lbConvert");
            this.lbConvert.Name = "lbConvert";
            // 
            // pbConvert
            // 
            resources.ApplyResources(this.pbConvert, "pbConvert");
            this.pbConvert.Name = "pbConvert";
            this.pbConvert.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // cbPower
            // 
            resources.ApplyResources(this.cbPower, "cbPower");
            this.cbPower.Name = "cbPower";
            this.cbPower.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbPower.UseSelectable = true;
            // 
            // metroButton11
            // 
            this.metroButton11.BackColor = System.Drawing.Color.DarkOrange;
            this.metroButton11.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.metroButton11, "metroButton11");
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton11.UseCustomBackColor = true;
            this.metroButton11.UseCustomForeColor = true;
            this.metroButton11.UseSelectable = true;
            this.metroButton11.Click += new System.EventHandler(this.metroButton11_Click);
            // 
            // metroLabel9
            // 
            resources.ApplyResources(this.metroLabel9, "metroLabel9");
            this.metroLabel9.Name = "metroLabel9";
            // 
            // cbCards
            // 
            resources.ApplyResources(this.cbCards, "cbCards");
            this.cbCards.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbCards.FormattingEnabled = true;
            this.cbCards.Items.AddRange(new object[] {
            resources.GetString("cbCards.Items"),
            resources.GetString("cbCards.Items1"),
            resources.GetString("cbCards.Items2")});
            this.cbCards.Name = "cbCards";
            this.cbCards.PromptText = "Selecione...";
            this.cbCards.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbCards.UseSelectable = true;
            this.cbCards.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            resources.ApplyResources(this.metroLabel8, "metroLabel8");
            this.metroLabel8.Name = "metroLabel8";
            // 
            // cbFormat
            // 
            resources.ApplyResources(this.cbFormat, "cbFormat");
            this.cbFormat.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            resources.GetString("cbFormat.Items"),
            resources.GetString("cbFormat.Items1"),
            resources.GetString("cbFormat.Items2"),
            resources.GetString("cbFormat.Items3")});
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.PromptText = "Selecione...";
            this.cbFormat.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbFormat.UseSelectable = true;
            this.cbFormat.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            resources.ApplyResources(this.metroLabel7, "metroLabel7");
            this.metroLabel7.Name = "metroLabel7";
            // 
            // cbSpeed
            // 
            resources.ApplyResources(this.cbSpeed, "cbSpeed");
            this.cbSpeed.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            resources.GetString("cbSpeed.Items"),
            resources.GetString("cbSpeed.Items1"),
            resources.GetString("cbSpeed.Items2"),
            resources.GetString("cbSpeed.Items3"),
            resources.GetString("cbSpeed.Items4")});
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.PromptText = "Selecione...";
            this.cbSpeed.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbSpeed.UseSelectable = true;
            this.cbSpeed.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            resources.ApplyResources(this.metroLabel6, "metroLabel6");
            this.metroLabel6.Name = "metroLabel6";
            // 
            // cbBits
            // 
            resources.ApplyResources(this.cbBits, "cbBits");
            this.cbBits.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbBits.FormattingEnabled = true;
            this.cbBits.Items.AddRange(new object[] {
            resources.GetString("cbBits.Items"),
            resources.GetString("cbBits.Items1"),
            resources.GetString("cbBits.Items2"),
            resources.GetString("cbBits.Items3"),
            resources.GetString("cbBits.Items4")});
            this.cbBits.Name = "cbBits";
            this.cbBits.PromptText = "Selecione...";
            this.cbBits.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbBits.UseSelectable = true;
            this.cbBits.UseStyleColors = true;
            // 
            // lbConvertFiles
            // 
            this.lbConvertFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbConvertFiles.FormattingEnabled = true;
            resources.ApplyResources(this.lbConvertFiles, "lbConvertFiles");
            this.lbConvertFiles.Name = "lbConvertFiles";
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.Name = "metroLabel5";
            // 
            // btnSelectExit
            // 
            this.btnSelectExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelectExit.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSelectExit, "btnSelectExit");
            this.btnSelectExit.Name = "btnSelectExit";
            this.btnSelectExit.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSelectExit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSelectExit.UseCustomBackColor = true;
            this.btnSelectExit.UseCustomForeColor = true;
            this.btnSelectExit.UseSelectable = true;
            this.btnSelectExit.Click += new System.EventHandler(this.btnSelectExit_Click);
            // 
            // tbConvertExit
            // 
            // 
            // 
            // 
            this.tbConvertExit.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription4");
            this.tbConvertExit.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName4");
            this.tbConvertExit.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.tbConvertExit.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.tbConvertExit.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.tbConvertExit.CustomButton.Name = "";
            this.tbConvertExit.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.tbConvertExit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbConvertExit.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.tbConvertExit.CustomButton.Text = resources.GetString("resource.Text4");
            this.tbConvertExit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbConvertExit.CustomButton.UseSelectable = true;
            this.tbConvertExit.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.tbConvertExit.DisplayIcon = true;
            this.tbConvertExit.Icon = global::MultiVideoTools.Properties.Resources.folder__2_;
            this.tbConvertExit.Lines = new string[0];
            resources.ApplyResources(this.tbConvertExit, "tbConvertExit");
            this.tbConvertExit.MaxLength = 32767;
            this.tbConvertExit.Name = "tbConvertExit";
            this.tbConvertExit.PasswordChar = '\0';
            this.tbConvertExit.PromptText = "Local de saida dos videos convertidos";
            this.tbConvertExit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConvertExit.SelectedText = "";
            this.tbConvertExit.SelectionLength = 0;
            this.tbConvertExit.SelectionStart = 0;
            this.tbConvertExit.ShortcutsEnabled = true;
            this.tbConvertExit.ShowClearButton = true;
            this.tbConvertExit.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbConvertExit.UseSelectable = true;
            this.tbConvertExit.WaterMark = "Local de saida dos videos convertidos";
            this.tbConvertExit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbConvertExit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddConvert
            // 
            this.btnAddConvert.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddConvert.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAddConvert, "btnAddConvert");
            this.btnAddConvert.Name = "btnAddConvert";
            this.btnAddConvert.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddConvert.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddConvert.UseCustomBackColor = true;
            this.btnAddConvert.UseCustomForeColor = true;
            this.btnAddConvert.UseSelectable = true;
            this.btnAddConvert.Click += new System.EventHandler(this.btnAddConvert_Click);
            // 
            // tbConvertLocal
            // 
            // 
            // 
            // 
            this.tbConvertLocal.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription5");
            this.tbConvertLocal.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName5");
            this.tbConvertLocal.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.tbConvertLocal.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode5")));
            this.tbConvertLocal.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location5")));
            this.tbConvertLocal.CustomButton.Name = "";
            this.tbConvertLocal.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size5")));
            this.tbConvertLocal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbConvertLocal.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex5")));
            this.tbConvertLocal.CustomButton.Text = resources.GetString("resource.Text5");
            this.tbConvertLocal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbConvertLocal.CustomButton.UseSelectable = true;
            this.tbConvertLocal.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible5")));
            this.tbConvertLocal.DisplayIcon = true;
            this.tbConvertLocal.Icon = global::MultiVideoTools.Properties.Resources.video;
            this.tbConvertLocal.Lines = new string[0];
            resources.ApplyResources(this.tbConvertLocal, "tbConvertLocal");
            this.tbConvertLocal.MaxLength = 32767;
            this.tbConvertLocal.Name = "tbConvertLocal";
            this.tbConvertLocal.PasswordChar = '\0';
            this.tbConvertLocal.PromptText = "Arquivos de video para conversão";
            this.tbConvertLocal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConvertLocal.SelectedText = "";
            this.tbConvertLocal.SelectionLength = 0;
            this.tbConvertLocal.SelectionStart = 0;
            this.tbConvertLocal.ShortcutsEnabled = true;
            this.tbConvertLocal.ShowClearButton = true;
            this.tbConvertLocal.Style = MetroFramework.MetroColorStyle.Orange;
            this.tbConvertLocal.UseSelectable = true;
            this.tbConvertLocal.WaterMark = "Arquivos de video para conversão";
            this.tbConvertLocal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbConvertLocal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPercent
            // 
            resources.ApplyResources(this.lbPercent, "lbPercent");
            this.lbPercent.Name = "lbPercent";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroTextBox tbVideoLink;
        private MetroFramework.Controls.MetroButton btnAddVideo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listBoxLinksVideos;
        private MetroFramework.Controls.MetroButton btnDownloadVideos;
        private MetroFramework.Controls.MetroButton btnCleanVideos;
        private MetroFramework.Controls.MetroButton btnLocationVideo;
        private MetroFramework.Controls.MetroTextBox tbLocationVideo;
        private MetroFramework.Controls.MetroProgressBar pbDownloadVideo;
        private MetroFramework.Controls.MetroLabel labelStatusVideo;
        private MetroFramework.Controls.MetroLabel labelStatusMusic;
        private MetroFramework.Controls.MetroProgressBar pbDownloadMusic;
        private MetroFramework.Controls.MetroButton btnLocationMusic;
        private MetroFramework.Controls.MetroTextBox tbLocationMusic;
        private MetroFramework.Controls.MetroButton btnCleanMusic;
        private MetroFramework.Controls.MetroButton btnDownloadMusic;
        private System.Windows.Forms.ListBox listBoxLinksMusic;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnAddMusic;
        private MetroFramework.Controls.MetroTextBox tbMusicLink;
        private MetroFramework.Controls.MetroButton btnAddConvert;
        private MetroFramework.Controls.MetroTextBox tbConvertLocal;
        private MetroFramework.Controls.MetroButton btnSelectExit;
        private MetroFramework.Controls.MetroTextBox tbConvertExit;
        private System.Windows.Forms.ListBox lbConvertFiles;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbBits;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbSpeed;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbFormat;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cbCards;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroCheckBox cbPower;
        private MetroFramework.Controls.MetroLabel lbConvert;
        private MetroFramework.Controls.MetroProgressBar pbConvert;
        private MetroFramework.Controls.MetroLabel lbPercent;
    }
}

