namespace WindowsFormsApp1
{
    partial class BattaPlayerApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattaPlayerApp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topPanel = new System.Windows.Forms.Panel();
            this.buttonDBTeszt = new System.Windows.Forms.Button();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxFullScreen = new System.Windows.Forms.PictureBox();
            this.pboxCloseIcon = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottomInner = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonClearSongs = new System.Windows.Forms.Button();
            this.dataGridViewSongs = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomOuter = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarMedia = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPlayPause = new System.Windows.Forms.PictureBox();
            this.pictureBoxStopButton = new System.Windows.Forms.PictureBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.pictureBoxNextButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreviousButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxVolumeMute = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerMedia = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuDropDownPlaylists = new CxMenu.CxDropDown.MenuDropDown(this.components);
            this.toolStripAddPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMediaName = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseIcon)).BeginInit();
            this.tableLayoutPanelBottomInner.SuspendLayout();
            this.tableLayoutRight.SuspendLayout();
            this.tableLayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.tableLayoutLeft.SuspendLayout();
            this.tableLayoutPanelBottomOuter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolumeMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuDropDownPlaylists.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Purple;
            this.topPanel.Controls.Add(this.buttonDBTeszt);
            this.topPanel.Controls.Add(this.pictureBoxMinimize);
            this.topPanel.Controls.Add(this.pictureBoxFullScreen);
            this.topPanel.Controls.Add(this.pboxCloseIcon);
            this.topPanel.Controls.Add(this.labelLogo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(824, 30);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // buttonDBTeszt
            // 
            this.buttonDBTeszt.Location = new System.Drawing.Point(145, 4);
            this.buttonDBTeszt.Name = "buttonDBTeszt";
            this.buttonDBTeszt.Size = new System.Drawing.Size(75, 23);
            this.buttonDBTeszt.TabIndex = 4;
            this.buttonDBTeszt.Text = "teszt";
            this.buttonDBTeszt.UseVisualStyleBackColor = true;
            this.buttonDBTeszt.Click += new System.EventHandler(this.buttonDBTeszt_Click);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(736, 0);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 3;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click_1);
            // 
            // pictureBoxFullScreen
            // 
            this.pictureBoxFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFullScreen.Image")));
            this.pictureBoxFullScreen.Location = new System.Drawing.Point(766, 0);
            this.pictureBoxFullScreen.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxFullScreen.Name = "pictureBoxFullScreen";
            this.pictureBoxFullScreen.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBoxFullScreen.Size = new System.Drawing.Size(28, 30);
            this.pictureBoxFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFullScreen.TabIndex = 2;
            this.pictureBoxFullScreen.TabStop = false;
            this.pictureBoxFullScreen.Click += new System.EventHandler(this.pictureBoxFullScreen_Click);
            // 
            // pboxCloseIcon
            // 
            this.pboxCloseIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxCloseIcon.Image = ((System.Drawing.Image)(resources.GetObject("pboxCloseIcon.Image")));
            this.pboxCloseIcon.Location = new System.Drawing.Point(794, 0);
            this.pboxCloseIcon.Margin = new System.Windows.Forms.Padding(5);
            this.pboxCloseIcon.Name = "pboxCloseIcon";
            this.pboxCloseIcon.Size = new System.Drawing.Size(30, 30);
            this.pboxCloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCloseIcon.TabIndex = 1;
            this.pboxCloseIcon.TabStop = false;
            this.pboxCloseIcon.Click += new System.EventHandler(this.pboxCloseIcon_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.Location = new System.Drawing.Point(12, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(77, 13);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Batta Player";
            // 
            // tableLayoutPanelBottomInner
            // 
            this.tableLayoutPanelBottomInner.AutoSize = true;
            this.tableLayoutPanelBottomInner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelBottomInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tableLayoutPanelBottomInner.ColumnCount = 2;
            this.tableLayoutPanelBottomInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.69903F));
            this.tableLayoutPanelBottomInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.30097F));
            this.tableLayoutPanelBottomInner.Controls.Add(this.tableLayoutRight, 1, 0);
            this.tableLayoutPanelBottomInner.Controls.Add(this.tableLayoutLeft, 0, 0);
            this.tableLayoutPanelBottomInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomInner.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanelBottomInner.Name = "tableLayoutPanelBottomInner";
            this.tableLayoutPanelBottomInner.RowCount = 1;
            this.tableLayoutPanelBottomInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanelBottomInner.Size = new System.Drawing.Size(824, 522);
            this.tableLayoutPanelBottomInner.TabIndex = 6;
            // 
            // tableLayoutRight
            // 
            this.tableLayoutRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tableLayoutRight.ColumnCount = 1;
            this.tableLayoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRight.Controls.Add(this.tableLayoutButtons, 0, 1);
            this.tableLayoutRight.Controls.Add(this.dataGridViewSongs, 0, 0);
            this.tableLayoutRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutRight.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutRight.Location = new System.Drawing.Point(632, 0);
            this.tableLayoutRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutRight.Name = "tableLayoutRight";
            this.tableLayoutRight.RowCount = 2;
            this.tableLayoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53F));
            this.tableLayoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47F));
            this.tableLayoutRight.Size = new System.Drawing.Size(192, 522);
            this.tableLayoutRight.TabIndex = 5;
            this.tableLayoutRight.SizeChanged += new System.EventHandler(this.tableLayoutRight_SizeChanged);
            // 
            // tableLayoutButtons
            // 
            this.tableLayoutButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tableLayoutButtons.ColumnCount = 2;
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtons.Controls.Add(this.buttonImport, 0, 0);
            this.tableLayoutButtons.Controls.Add(this.buttonClearSongs, 1, 0);
            this.tableLayoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutButtons.Location = new System.Drawing.Point(3, 470);
            this.tableLayoutButtons.Name = "tableLayoutButtons";
            this.tableLayoutButtons.RowCount = 1;
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtons.Size = new System.Drawing.Size(186, 49);
            this.tableLayoutButtons.TabIndex = 0;
            this.tableLayoutButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutButtons_Paint);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonImport.Enabled = false;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(3, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(87, 43);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.TabStop = false;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.SizeChanged += new System.EventHandler(this.buttonImport_SizeChanged);
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonClearSongs
            // 
            this.buttonClearSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonClearSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearSongs.Enabled = false;
            this.buttonClearSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSongs.ForeColor = System.Drawing.Color.White;
            this.buttonClearSongs.Location = new System.Drawing.Point(96, 3);
            this.buttonClearSongs.Name = "buttonClearSongs";
            this.buttonClearSongs.Size = new System.Drawing.Size(87, 43);
            this.buttonClearSongs.TabIndex = 3;
            this.buttonClearSongs.TabStop = false;
            this.buttonClearSongs.Text = "Clear";
            this.buttonClearSongs.UseVisualStyleBackColor = false;
            this.buttonClearSongs.SizeChanged += new System.EventHandler(this.buttonClearSongs_SizeChanged);
            this.buttonClearSongs.Click += new System.EventHandler(this.buttonClearSongs_Click);
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.AllowDrop = true;
            this.dataGridViewSongs.AllowUserToAddRows = false;
            this.dataGridViewSongs.AllowUserToDeleteRows = false;
            this.dataGridViewSongs.AllowUserToOrderColumns = true;
            this.dataGridViewSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSongs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.number,
            this.Title});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSongs.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSongs.EnableHeadersVisualStyles = false;
            this.dataGridViewSongs.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.RowHeadersVisible = false;
            this.dataGridViewSongs.Size = new System.Drawing.Size(186, 461);
            this.dataGridViewSongs.TabIndex = 1;
            this.dataGridViewSongs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSongs_CellClick);
            this.dataGridViewSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSongs_CellContentClick);
            this.dataGridViewSongs.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewSongs_RowPrePaint);
            this.dataGridViewSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewSongs_DragDrop);
            this.dataGridViewSongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewSongs_DragEnter);
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Visible = false;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 40;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.ColumnCount = 2;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLeft.Controls.Add(this.tableLayoutPanelBottomOuter, 0, 1);
            this.tableLayoutLeft.Controls.Add(this.button1, 1, 0);
            this.tableLayoutLeft.Controls.Add(this.WindowsMediaPlayer1, 0, 0);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 2;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53488F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46512F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(626, 516);
            this.tableLayoutLeft.TabIndex = 6;
            this.tableLayoutLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutLeft_Paint);
            // 
            // tableLayoutPanelBottomOuter
            // 
            this.tableLayoutPanelBottomOuter.ColumnCount = 1;
            this.tableLayoutPanelBottomOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBottomOuter.Controls.Add(this.progressBarMedia, 0, 0);
            this.tableLayoutPanelBottomOuter.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelBottomOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomOuter.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanelBottomOuter.Name = "tableLayoutPanelBottomOuter";
            this.tableLayoutPanelBottomOuter.RowCount = 2;
            this.tableLayoutPanelBottomOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanelBottomOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanelBottomOuter.Size = new System.Drawing.Size(600, 48);
            this.tableLayoutPanelBottomOuter.TabIndex = 4;
            // 
            // progressBarMedia
            // 
            this.progressBarMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarMedia.Location = new System.Drawing.Point(3, 3);
            this.progressBarMedia.Name = "progressBarMedia";
            this.progressBarMedia.Size = new System.Drawing.Size(594, 12);
            this.progressBarMedia.TabIndex = 0;
            this.progressBarMedia.Click += new System.EventHandler(this.progressBarMedia_Click);
            this.progressBarMedia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBarMedia_MouseMove);
            this.progressBarMedia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBarMedia_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.094464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.094464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.094464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.094464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.094464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.22042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0838F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.22346F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPlayPause, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStopButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProgress, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxNextButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPreviousButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxVolumeMute, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarVolume, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMediaName, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 24);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBoxPlayPause
            // 
            this.pictureBoxPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayPause.Image")));
            this.pictureBoxPlayPause.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayPause.InitialImage")));
            this.pictureBoxPlayPause.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlayPause.Name = "pictureBoxPlayPause";
            this.pictureBoxPlayPause.Size = new System.Drawing.Size(16, 18);
            this.pictureBoxPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayPause.TabIndex = 2;
            this.pictureBoxPlayPause.TabStop = false;
            this.pictureBoxPlayPause.SizeChanged += new System.EventHandler(this.pictureBoxPlayPause_SizeChanged);
            this.pictureBoxPlayPause.Click += new System.EventHandler(this.pictureBoxPlayPause_Click);
            // 
            // pictureBoxStopButton
            // 
            this.pictureBoxStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxStopButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStopButton.Image")));
            this.pictureBoxStopButton.Location = new System.Drawing.Point(39, 3);
            this.pictureBoxStopButton.Name = "pictureBoxStopButton";
            this.pictureBoxStopButton.Size = new System.Drawing.Size(16, 18);
            this.pictureBoxStopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStopButton.TabIndex = 3;
            this.pictureBoxStopButton.TabStop = false;
            this.pictureBoxStopButton.SizeChanged += new System.EventHandler(this.pictureBoxStopButton_SizeChanged);
            this.pictureBoxStopButton.Click += new System.EventHandler(this.pictureBoxStopButton_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgress.Location = new System.Drawing.Point(267, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(83, 24);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "0:00 / 0:00";
            this.labelProgress.SizeChanged += new System.EventHandler(this.labelProgress_SizeChanged);
            this.labelProgress.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxNextButton
            // 
            this.pictureBoxNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxNextButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNextButton.Image")));
            this.pictureBoxNextButton.Location = new System.Drawing.Point(111, 3);
            this.pictureBoxNextButton.Name = "pictureBoxNextButton";
            this.pictureBoxNextButton.Size = new System.Drawing.Size(16, 18);
            this.pictureBoxNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNextButton.TabIndex = 5;
            this.pictureBoxNextButton.TabStop = false;
            this.pictureBoxNextButton.SizeChanged += new System.EventHandler(this.pictureBoxNextButton_SizeChanged);
            this.pictureBoxNextButton.Click += new System.EventHandler(this.pictureBoxNextButton_Click);
            // 
            // pictureBoxPreviousButton
            // 
            this.pictureBoxPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxPreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreviousButton.Image")));
            this.pictureBoxPreviousButton.Location = new System.Drawing.Point(75, 3);
            this.pictureBoxPreviousButton.Name = "pictureBoxPreviousButton";
            this.pictureBoxPreviousButton.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxPreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreviousButton.TabIndex = 4;
            this.pictureBoxPreviousButton.TabStop = false;
            this.pictureBoxPreviousButton.SizeChanged += new System.EventHandler(this.pictureBoxPreviousButton_SizeChanged);
            this.pictureBoxPreviousButton.Click += new System.EventHandler(this.pictureBoxPreviousButton_Click);
            // 
            // pictureBoxVolumeMute
            // 
            this.pictureBoxVolumeMute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxVolumeMute.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolumeMute.Image")));
            this.pictureBoxVolumeMute.Location = new System.Drawing.Point(147, 3);
            this.pictureBoxVolumeMute.Name = "pictureBoxVolumeMute";
            this.pictureBoxVolumeMute.Size = new System.Drawing.Size(16, 18);
            this.pictureBoxVolumeMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVolumeMute.TabIndex = 6;
            this.pictureBoxVolumeMute.TabStop = false;
            this.pictureBoxVolumeMute.SizeChanged += new System.EventHandler(this.pictureBoxVolumeMute_SizeChanged);
            this.pictureBoxVolumeMute.Click += new System.EventHandler(this.pictureBoxVolumeMute_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trackBarVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarVolume.Location = new System.Drawing.Point(183, 3);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(78, 18);
            this.trackBarVolume.TabIndex = 7;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(609, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 456);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowsMediaPlayer1
            // 
            this.WindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer1.Enabled = true;
            this.WindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.WindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1";
            this.WindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer1.OcxState")));
            this.WindowsMediaPlayer1.Size = new System.Drawing.Size(606, 462);
            this.WindowsMediaPlayer1.TabIndex = 3;
            this.WindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowsMediaPlayer1_PlayStateChange);
            this.WindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.WindowsMediaPlayer1_MediaChange);
            // 
            // timerMedia
            // 
            this.timerMedia.Tick += new System.EventHandler(this.timerMedia_Tick);
            // 
            // menuDropDownPlaylists
            // 
            this.menuDropDownPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuDropDownPlaylists.IsMainMenu = false;
            this.menuDropDownPlaylists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddPlaylist,
            this.toolStripMenuShowAll});
            this.menuDropDownPlaylists.MenuItemheight = 25;
            this.menuDropDownPlaylists.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.menuDropDownPlaylists.Name = "menuDropDown1";
            this.menuDropDownPlaylists.PrimaryColor = System.Drawing.Color.White;
            this.menuDropDownPlaylists.Size = new System.Drawing.Size(156, 48);
            this.menuDropDownPlaylists.UseWaitCursor = true;
            this.menuDropDownPlaylists.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.menuDropDownPlaylists_Closing);
            this.menuDropDownPlaylists.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuDropDown1_ItemClicked);
            // 
            // toolStripAddPlaylist
            // 
            this.toolStripAddPlaylist.Name = "toolStripAddPlaylist";
            this.toolStripAddPlaylist.Size = new System.Drawing.Size(155, 22);
            this.toolStripAddPlaylist.Text = "Add Playlist (+)";
            // 
            // toolStripMenuShowAll
            // 
            this.toolStripMenuShowAll.Name = "toolStripMenuShowAll";
            this.toolStripMenuShowAll.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuShowAll.Text = "Show All";
            // 
            // labelMediaName
            // 
            this.labelMediaName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMediaName.AutoSize = true;
            this.labelMediaName.Location = new System.Drawing.Point(356, 0);
            this.labelMediaName.Name = "labelMediaName";
            this.labelMediaName.Size = new System.Drawing.Size(235, 24);
            this.labelMediaName.TabIndex = 8;
            this.labelMediaName.Text = "mediaName";
            this.labelMediaName.SizeChanged += new System.EventHandler(this.labelMediaName_SizeChanged);
            this.labelMediaName.Click += new System.EventHandler(this.labelMediaName_Click);
            // 
            // BattaPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(824, 552);
            this.Controls.Add(this.tableLayoutPanelBottomInner);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BattaPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BattaPlayerApp_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCloseIcon)).EndInit();
            this.tableLayoutPanelBottomInner.ResumeLayout(false);
            this.tableLayoutRight.ResumeLayout(false);
            this.tableLayoutButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.tableLayoutLeft.ResumeLayout(false);
            this.tableLayoutPanelBottomOuter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolumeMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuDropDownPlaylists.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pboxCloseIcon;
        private System.Windows.Forms.Label labelLogo;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomInner;
        private System.Windows.Forms.PictureBox pictureBoxFullScreen;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomOuter;
        private System.Windows.Forms.ProgressBar progressBarMedia;
        private System.Windows.Forms.Timer timerMedia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.PictureBox pictureBoxPlayPause;
        private System.Windows.Forms.PictureBox pictureBoxStopButton;
        private System.Windows.Forms.PictureBox pictureBoxNextButton;
        private System.Windows.Forms.PictureBox pictureBoxPreviousButton;
        private System.Windows.Forms.PictureBox pictureBoxVolumeMute;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.DataGridView dataGridViewSongs;
        private System.Windows.Forms.Button buttonClearSongs;
        private System.Windows.Forms.Button buttonDBTeszt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.Button button1;
        private CxMenu.CxDropDown.MenuDropDown menuDropDownPlaylists;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuShowAll;
        private System.Windows.Forms.Label labelMediaName;
    }
}

