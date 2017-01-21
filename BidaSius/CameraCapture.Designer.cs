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
            this.captureButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboGame = new System.Windows.Forms.ComboBox();
            this.buttonPauseAndSelect = new System.Windows.Forms.Button();
            this.trackThreshOne = new System.Windows.Forms.TrackBar();
            this.trackthreshTwo = new System.Windows.Forms.TrackBar();
            this.trackthresh4 = new System.Windows.Forms.TrackBar();
            this.trackthresh3 = new System.Windows.Forms.TrackBar();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackthreshTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackthresh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackthresh3)).BeginInit();
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
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.captureButton);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.buttonPauseAndSelect);
            this.tabPage1.Controls.Add(this.trackThreshOne);
            this.tabPage1.Controls.Add(this.trackthreshTwo);
            this.tabPage1.Controls.Add(this.trackthresh4);
            this.tabPage1.Controls.Add(this.trackthresh3);
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.comboGame);
            this.groupBox4.Location = new System.Drawing.Point(193, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 75);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trening";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // comboGame
            // 
            this.comboGame.FormattingEnabled = true;
            this.comboGame.Items.AddRange(new object[] {
            "naked",
            "normal"});
            this.comboGame.Location = new System.Drawing.Point(19, 24);
            this.comboGame.Name = "comboGame";
            this.comboGame.Size = new System.Drawing.Size(121, 21);
            this.comboGame.TabIndex = 0;
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
            // trackThreshOne
            // 
            this.trackThreshOne.Location = new System.Drawing.Point(314, 11);
            this.trackThreshOne.Maximum = 300;
            this.trackThreshOne.Name = "trackThreshOne";
            this.trackThreshOne.Size = new System.Drawing.Size(172, 45);
            this.trackThreshOne.TabIndex = 38;
            this.trackThreshOne.Value = 100;
            // 
            // trackthreshTwo
            // 
            this.trackthreshTwo.Location = new System.Drawing.Point(314, 66);
            this.trackthreshTwo.Maximum = 300;
            this.trackthreshTwo.Name = "trackthreshTwo";
            this.trackthreshTwo.Size = new System.Drawing.Size(172, 45);
            this.trackthreshTwo.TabIndex = 40;
            this.trackthreshTwo.Value = 60;
            // 
            // trackthresh4
            // 
            this.trackthresh4.Location = new System.Drawing.Point(314, 171);
            this.trackthresh4.Maximum = 300;
            this.trackthresh4.Name = "trackthresh4";
            this.trackthresh4.Size = new System.Drawing.Size(172, 45);
            this.trackthresh4.TabIndex = 41;
            this.trackthresh4.Value = 18;
            // 
            // trackthresh3
            // 
            this.trackthresh3.Location = new System.Drawing.Point(314, 120);
            this.trackthresh3.Maximum = 300;
            this.trackthresh3.Name = "trackthresh3";
            this.trackthresh3.Size = new System.Drawing.Size(172, 45);
            this.trackthresh3.TabIndex = 39;
            this.trackthresh3.Value = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(492, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 120);
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
            this.groupBox3.Controls.Add(this.lblCamNo);
            this.groupBox3.Controls.Add(this.numericCameraNo);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 76);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // lblCamNo
            // 
            this.lblCamNo.AutoSize = true;
            this.lblCamNo.Location = new System.Drawing.Point(11, 21);
            this.lblCamNo.Name = "lblCamNo";
            this.lblCamNo.Size = new System.Drawing.Size(83, 13);
            this.lblCamNo.TabIndex = 33;
            this.lblCamNo.Text = "Camera Number";
            // 
            // numericCameraNo
            // 
            this.numericCameraNo.Location = new System.Drawing.Point(100, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
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
            this.numBLCx.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.numBLCy.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.numBLCKradius.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxBLX.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxTL.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxBRX.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxTR.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxTRX.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxBR.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxTLX.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
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
            this.textBoxBL.ValueChanged += new System.EventHandler(this.textBoxTLX_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackthreshTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackthresh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackthresh3)).EndInit();
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
        private System.Windows.Forms.TrackBar trackThreshOne;
        private System.Windows.Forms.TrackBar trackthreshTwo;
        private System.Windows.Forms.TrackBar trackthresh4;
        private System.Windows.Forms.TrackBar trackthresh3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
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
    }
}

