namespace tarcza
{
    partial class CameraCapture
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
            ReleaseData();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUDThreshOne = new System.Windows.Forms.NumericUpDown();
            this.numericUDthreshTwo = new System.Windows.Forms.NumericUpDown();
            this.numericUDthresh3 = new System.Windows.Forms.NumericUpDown();
            this.numericUDThresh4 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxIgnoreWhiteShots = new System.Windows.Forms.CheckBox();
            this.comboGame = new System.Windows.Forms.ComboBox();
            this.buttonPauseAndSelect = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTestCom = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.comboComPorts = new System.Windows.Forms.ComboBox();
            this.File = new System.Windows.Forms.GroupBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxCameraFlipped = new System.Windows.Forms.CheckBox();
            this.checkBoxCameraOnTop = new System.Windows.Forms.CheckBox();
            this.lblCamNo = new System.Windows.Forms.Label();
            this.numericCameraNo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numBLCx = new System.Windows.Forms.NumericUpDown();
            this.numBLCy = new System.Windows.Forms.NumericUpDown();
            this.numBLCKradius = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBLX = new System.Windows.Forms.NumericUpDown();
            this.textBoxTL = new System.Windows.Forms.NumericUpDown();
            this.textBoxBRX = new System.Windows.Forms.NumericUpDown();
            this.textBoxTR = new System.Windows.Forms.NumericUpDown();
            this.textBoxTRX = new System.Windows.Forms.NumericUpDown();
            this.textBoxBR = new System.Windows.Forms.NumericUpDown();
            this.textBoxTLX = new System.Windows.Forms.NumericUpDown();
            this.textBoxBL = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDThreshOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDthreshTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDthresh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDThresh4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.File.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCameraNo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBLCx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBLCy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBLCKradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBL)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 341);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.numericUDThreshOne);
            this.tabPage1.Controls.Add(this.numericUDthreshTwo);
            this.tabPage1.Controls.Add(this.numericUDthresh3);
            this.tabPage1.Controls.Add(this.numericUDThresh4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.captureButton);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.buttonPauseAndSelect);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.File);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUDThreshOne
            // 
            this.numericUDThreshOne.Location = new System.Drawing.Point(314, 11);
            this.numericUDThreshOne.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUDThreshOne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDThreshOne.Name = "numericUDThreshOne";
            this.numericUDThreshOne.Size = new System.Drawing.Size(50, 20);
            this.numericUDThreshOne.TabIndex = 54;
            this.numericUDThreshOne.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUDthreshTwo
            // 
            this.numericUDthreshTwo.Location = new System.Drawing.Point(314, 37);
            this.numericUDthreshTwo.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUDthreshTwo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDthreshTwo.Name = "numericUDthreshTwo";
            this.numericUDthreshTwo.Size = new System.Drawing.Size(50, 20);
            this.numericUDthreshTwo.TabIndex = 53;
            this.numericUDthreshTwo.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numericUDthresh3
            // 
            this.numericUDthresh3.Location = new System.Drawing.Point(314, 63);
            this.numericUDthresh3.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUDthresh3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDthresh3.Name = "numericUDthresh3";
            this.numericUDthresh3.Size = new System.Drawing.Size(50, 20);
            this.numericUDthresh3.TabIndex = 52;
            this.numericUDthresh3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUDThresh4
            // 
            this.numericUDThresh4.Location = new System.Drawing.Point(314, 89);
            this.numericUDThresh4.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUDThresh4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDThresh4.Name = "numericUDThresh4";
            this.numericUDThresh4.Size = new System.Drawing.Size(50, 20);
            this.numericUDThresh4.TabIndex = 51;
            this.numericUDThresh4.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(485, 236);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(71, 62);
            this.captureButton.TabIndex = 48;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.CaptureButtonClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxIgnoreWhiteShots);
            this.groupBox4.Controls.Add(this.comboGame);
            this.groupBox4.Location = new System.Drawing.Point(193, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 75);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trening";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBoxIgnoreWhiteShots
            // 
            this.checkBoxIgnoreWhiteShots.AutoSize = true;
            this.checkBoxIgnoreWhiteShots.Location = new System.Drawing.Point(19, 47);
            this.checkBoxIgnoreWhiteShots.Name = "checkBoxIgnoreWhiteShots";
            this.checkBoxIgnoreWhiteShots.Size = new System.Drawing.Size(123, 17);
            this.checkBoxIgnoreWhiteShots.TabIndex = 35;
            this.checkBoxIgnoreWhiteShots.Text = "Ignore shots in white";
            this.checkBoxIgnoreWhiteShots.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreWhiteShots.CheckedChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // comboGame
            // 
            this.comboGame.FormattingEnabled = true;
            this.comboGame.Items.AddRange(new object[] {
            "naked",
            "normal",
            "TenSeries"});
            this.comboGame.Location = new System.Drawing.Point(19, 19);
            this.comboGame.Name = "comboGame";
            this.comboGame.Size = new System.Drawing.Size(121, 21);
            this.comboGame.TabIndex = 0;
            this.comboGame.SelectedIndexChanged += new System.EventHandler(this.comboGame_SelectedIndexChanged);
            // 
            // buttonPauseAndSelect
            // 
            this.buttonPauseAndSelect.Location = new System.Drawing.Point(369, 236);
            this.buttonPauseAndSelect.Name = "buttonPauseAndSelect";
            this.buttonPauseAndSelect.Size = new System.Drawing.Size(100, 61);
            this.buttonPauseAndSelect.TabIndex = 46;
            this.buttonPauseAndSelect.Text = "Pauzuj Poka¿ Zapisz";
            this.buttonPauseAndSelect.UseVisualStyleBackColor = true;
            this.buttonPauseAndSelect.Click += new System.EventHandler(this.buttonPauseAndSelect_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "label9";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTestCom);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.comboComPorts);
            this.groupBox2.Location = new System.Drawing.Point(8, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 76);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // buttonTestCom
            // 
            this.buttonTestCom.Location = new System.Drawing.Point(9, 42);
            this.buttonTestCom.Name = "buttonTestCom";
            this.buttonTestCom.Size = new System.Drawing.Size(147, 23);
            this.buttonTestCom.TabIndex = 11;
            this.buttonTestCom.Text = "Test Scroll";
            this.buttonTestCom.UseVisualStyleBackColor = true;
            this.buttonTestCom.Click += new System.EventHandler(this.buttonTestCom_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "COM port";
            // 
            // comboComPorts
            // 
            this.comboComPorts.FormattingEnabled = true;
            this.comboComPorts.Location = new System.Drawing.Point(64, 15);
            this.comboComPorts.Name = "comboComPorts";
            this.comboComPorts.Size = new System.Drawing.Size(92, 21);
            this.comboComPorts.TabIndex = 0;
            // 
            // File
            // 
            this.File.Controls.Add(this.fileNameTextBox);
            this.File.Controls.Add(this.openFileButton);
            this.File.Location = new System.Drawing.Point(181, 6);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(127, 76);
            this.File.TabIndex = 36;
            this.File.TabStop = false;
            this.File.Text = "File open";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 18);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(101, 20);
            this.fileNameTextBox.TabIndex = 33;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 45);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(101, 23);
            this.openFileButton.TabIndex = 34;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxCameraFlipped);
            this.groupBox3.Controls.Add(this.checkBoxCameraOnTop);
            this.groupBox3.Controls.Add(this.lblCamNo);
            this.groupBox3.Controls.Add(this.numericCameraNo);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 76);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // checkBoxCameraFlipped
            // 
            this.checkBoxCameraFlipped.AutoSize = true;
            this.checkBoxCameraFlipped.Location = new System.Drawing.Point(14, 53);
            this.checkBoxCameraFlipped.Name = "checkBoxCameraFlipped";
            this.checkBoxCameraFlipped.Size = new System.Drawing.Size(145, 17);
            this.checkBoxCameraFlipped.TabIndex = 35;
            this.checkBoxCameraFlipped.Text = "Camera flipped (upDown)";
            this.checkBoxCameraFlipped.UseVisualStyleBackColor = true;
            this.checkBoxCameraFlipped.CheckedChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // checkBoxCameraOnTop
            // 
            this.checkBoxCameraOnTop.AutoSize = true;
            this.checkBoxCameraOnTop.Location = new System.Drawing.Point(14, 38);
            this.checkBoxCameraOnTop.Name = "checkBoxCameraOnTop";
            this.checkBoxCameraOnTop.Size = new System.Drawing.Size(95, 17);
            this.checkBoxCameraOnTop.TabIndex = 34;
            this.checkBoxCameraOnTop.Text = "Camera on top";
            this.checkBoxCameraOnTop.UseVisualStyleBackColor = true;
            this.checkBoxCameraOnTop.CheckedChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // lblCamNo
            // 
            this.lblCamNo.AutoSize = true;
            this.lblCamNo.Location = new System.Drawing.Point(11, 17);
            this.lblCamNo.Name = "lblCamNo";
            this.lblCamNo.Size = new System.Drawing.Size(83, 13);
            this.lblCamNo.TabIndex = 33;
            this.lblCamNo.Text = "Camera Number";
            // 
            // numericCameraNo
            // 
            this.numericCameraNo.Location = new System.Drawing.Point(100, 15);
            this.numericCameraNo.Name = "numericCameraNo";
            this.numericCameraNo.Size = new System.Drawing.Size(42, 20);
            this.numericCameraNo.TabIndex = 32;
            this.numericCameraNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.numBLCx);
            this.groupBox1.Controls.Add(this.numBLCy);
            this.groupBox1.Controls.Add(this.numBLCKradius);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxBLX);
            this.groupBox1.Controls.Add(this.textBoxTL);
            this.groupBox1.Controls.Add(this.textBoxBRX);
            this.groupBox1.Controls.Add(this.textBoxTR);
            this.groupBox1.Controls.Add(this.textBoxTRX);
            this.groupBox1.Controls.Add(this.textBoxBR);
            this.groupBox1.Controls.Add(this.textBoxTLX);
            this.groupBox1.Controls.Add(this.textBoxBL);
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 128);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Details";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(182, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Black radius";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(182, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Black center x y";
            // 
            // numBLCx
            // 
            this.numBLCx.Location = new System.Drawing.Point(185, 32);
            this.numBLCx.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBLCx.Name = "numBLCx";
            this.numBLCx.Size = new System.Drawing.Size(50, 20);
            this.numBLCx.TabIndex = 27;
            this.numBLCx.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // numBLCy
            // 
            this.numBLCy.Location = new System.Drawing.Point(241, 32);
            this.numBLCy.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBLCy.Name = "numBLCy";
            this.numBLCy.Size = new System.Drawing.Size(50, 20);
            this.numBLCy.TabIndex = 26;
            this.numBLCy.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // numBLCKradius
            // 
            this.numBLCKradius.Location = new System.Drawing.Point(185, 72);
            this.numBLCKradius.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBLCKradius.Name = "numBLCKradius";
            this.numBLCKradius.Size = new System.Drawing.Size(50, 20);
            this.numBLCKradius.TabIndex = 25;
            this.numBLCKradius.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "BL x y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "BR x y ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "TR x y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "TL x y";
            // 
            // textBoxBLX
            // 
            this.textBoxBLX.Location = new System.Drawing.Point(52, 98);
            this.textBoxBLX.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxBLX.Name = "textBoxBLX";
            this.textBoxBLX.Size = new System.Drawing.Size(50, 20);
            this.textBoxBLX.TabIndex = 19;
            this.textBoxBLX.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxTL
            // 
            this.textBoxTL.Location = new System.Drawing.Point(108, 19);
            this.textBoxTL.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxTL.Name = "textBoxTL";
            this.textBoxTL.Size = new System.Drawing.Size(50, 20);
            this.textBoxTL.TabIndex = 12;
            this.textBoxTL.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxBRX
            // 
            this.textBoxBRX.Location = new System.Drawing.Point(52, 72);
            this.textBoxBRX.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxBRX.Name = "textBoxBRX";
            this.textBoxBRX.Size = new System.Drawing.Size(50, 20);
            this.textBoxBRX.TabIndex = 18;
            this.textBoxBRX.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxTR
            // 
            this.textBoxTR.Location = new System.Drawing.Point(108, 46);
            this.textBoxTR.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxTR.Name = "textBoxTR";
            this.textBoxTR.Size = new System.Drawing.Size(50, 20);
            this.textBoxTR.TabIndex = 13;
            this.textBoxTR.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxTRX
            // 
            this.textBoxTRX.Location = new System.Drawing.Point(52, 46);
            this.textBoxTRX.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxTRX.Name = "textBoxTRX";
            this.textBoxTRX.Size = new System.Drawing.Size(50, 20);
            this.textBoxTRX.TabIndex = 17;
            this.textBoxTRX.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxBR
            // 
            this.textBoxBR.Location = new System.Drawing.Point(108, 72);
            this.textBoxBR.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxBR.Name = "textBoxBR";
            this.textBoxBR.Size = new System.Drawing.Size(50, 20);
            this.textBoxBR.TabIndex = 14;
            this.textBoxBR.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxTLX
            // 
            this.textBoxTLX.Location = new System.Drawing.Point(52, 19);
            this.textBoxTLX.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxTLX.Name = "textBoxTLX";
            this.textBoxTLX.Size = new System.Drawing.Size(50, 20);
            this.textBoxTLX.TabIndex = 16;
            this.textBoxTLX.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // textBoxBL
            // 
            this.textBoxBL.Location = new System.Drawing.Point(108, 98);
            this.textBoxBL.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.textBoxBL.Name = "textBoxBL";
            this.textBoxBL.Size = new System.Drawing.Size(50, 20);
            this.textBoxBL.TabIndex = 15;
            this.textBoxBL.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 55;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "CameraCapture";
            this.ShowIcon = false;
            this.Text = "Camera Capture";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraCapture_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDThreshOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDthreshTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDthresh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDThresh4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCameraNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBLCx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBLCy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBLCKradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericCameraNo;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numBLCx;
        private System.Windows.Forms.NumericUpDown numBLCy;
        private System.Windows.Forms.NumericUpDown numBLCKradius;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown textBoxBLX;
        private System.Windows.Forms.NumericUpDown textBoxTL;
        private System.Windows.Forms.NumericUpDown textBoxBRX;
        private System.Windows.Forms.NumericUpDown textBoxTR;
        private System.Windows.Forms.NumericUpDown textBoxTRX;
        private System.Windows.Forms.NumericUpDown textBoxBR;
        private System.Windows.Forms.NumericUpDown textBoxTLX;
        private System.Windows.Forms.NumericUpDown textBoxBL;
        private System.Windows.Forms.GroupBox File;
        private System.Windows.Forms.Label lblCamNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTestCom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboComPorts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonPauseAndSelect;
        private System.Windows.Forms.ComboBox comboGame;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxCameraFlipped;
        private System.Windows.Forms.CheckBox checkBoxCameraOnTop;
        private System.Windows.Forms.CheckBox checkBoxIgnoreWhiteShots;
        private System.Windows.Forms.NumericUpDown numericUDThresh4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUDthresh3;
        private System.Windows.Forms.NumericUpDown numericUDThreshOne;
        private System.Windows.Forms.NumericUpDown numericUDthreshTwo;
        private System.Windows.Forms.Button button3;
    }
}

