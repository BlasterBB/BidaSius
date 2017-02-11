namespace BidaSius
{
    partial class PlayTenSeries
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
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelShotsSeries = new System.Windows.Forms.Label();
            this.numericShotsSeriesNum = new System.Windows.Forms.NumericUpDown();
            this.labelShotsNum = new System.Windows.Forms.Label();
            this.numericShotsNum = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRemoveLast = new System.Windows.Forms.Button();
            this.groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericShotsSeriesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericShotsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.buttonOk);
            this.groupSettings.Controls.Add(this.labelShotsSeries);
            this.groupSettings.Controls.Add(this.numericShotsSeriesNum);
            this.groupSettings.Controls.Add(this.labelShotsNum);
            this.groupSettings.Controls.Add(this.numericShotsNum);
            this.groupSettings.Location = new System.Drawing.Point(12, 12);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(428, 56);
            this.groupSettings.TabIndex = 0;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Ustawienia";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(332, 21);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Gramy";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelShotsSeries
            // 
            this.labelShotsSeries.AutoSize = true;
            this.labelShotsSeries.Location = new System.Drawing.Point(144, 26);
            this.labelShotsSeries.Name = "labelShotsSeries";
            this.labelShotsSeries.Size = new System.Drawing.Size(65, 13);
            this.labelShotsSeries.TabIndex = 5;
            this.labelShotsSeries.Text = "Ile 10 w serii";
            // 
            // numericShotsSeriesNum
            // 
            this.numericShotsSeriesNum.Location = new System.Drawing.Point(215, 24);
            this.numericShotsSeriesNum.Name = "numericShotsSeriesNum";
            this.numericShotsSeriesNum.Size = new System.Drawing.Size(45, 20);
            this.numericShotsSeriesNum.TabIndex = 4;
            this.numericShotsSeriesNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelShotsNum
            // 
            this.labelShotsNum.AutoSize = true;
            this.labelShotsNum.Location = new System.Drawing.Point(6, 26);
            this.labelShotsNum.Name = "labelShotsNum";
            this.labelShotsNum.Size = new System.Drawing.Size(53, 13);
            this.labelShotsNum.TabIndex = 2;
            this.labelShotsNum.Text = "Ile złożeń";
            // 
            // numericShotsNum
            // 
            this.numericShotsNum.Location = new System.Drawing.Point(65, 24);
            this.numericShotsNum.Name = "numericShotsNum";
            this.numericShotsNum.Size = new System.Drawing.Size(45, 20);
            this.numericShotsNum.TabIndex = 3;
            this.numericShotsNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericShotsNum.ValueChanged += new System.EventHandler(this.numericShotsNum_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 275);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonRemoveLast
            // 
            this.buttonRemoveLast.Location = new System.Drawing.Point(527, 33);
            this.buttonRemoveLast.Name = "buttonRemoveLast";
            this.buttonRemoveLast.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveLast.TabIndex = 2;
            this.buttonRemoveLast.Text = "usun ostatni";
            this.buttonRemoveLast.UseVisualStyleBackColor = true;
            this.buttonRemoveLast.Click += new System.EventHandler(this.buttonRemoveLast_Click);
            // 
            // PlayTenSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 357);
            this.Controls.Add(this.buttonRemoveLast);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupSettings);
            this.Name = "PlayTenSeries";
            this.Text = "PlayTenSeries";
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericShotsSeriesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericShotsNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelShotsSeries;
        private System.Windows.Forms.NumericUpDown numericShotsSeriesNum;
        private System.Windows.Forms.Label labelShotsNum;
        private System.Windows.Forms.NumericUpDown numericShotsNum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonRemoveLast;
    }
}