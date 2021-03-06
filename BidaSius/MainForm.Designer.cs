﻿namespace BidaSius
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TargetIB = new Emgu.CV.UI.ImageBox();
            this.splitContainerData = new System.Windows.Forms.SplitContainer();
            this.labelShotsInSeries = new System.Windows.Forms.Label();
            this.numericShotsInSeries = new System.Windows.Forms.NumericUpDown();
            this.buttonRepairLast = new System.Windows.Forms.Button();
            this.chckShowAll = new System.Windows.Forms.CheckBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonRemLast = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labSeries = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flPanelSeries = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetIB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData)).BeginInit();
            this.splitContainerData.Panel1.SuspendLayout();
            this.splitContainerData.Panel2.SuspendLayout();
            this.splitContainerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericShotsInSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TargetIB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerData);
            this.splitContainer1.Size = new System.Drawing.Size(1481, 811);
            this.splitContainer1.SplitterDistance = 694;
            this.splitContainer1.TabIndex = 0;
            // 
            // TargetIB
            // 
            this.TargetIB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetIB.HideScrolls = false;
            this.TargetIB.Location = new System.Drawing.Point(0, 0);
            this.TargetIB.Name = "TargetIB";
            this.TargetIB.Size = new System.Drawing.Size(694, 811);
            this.TargetIB.TabIndex = 2;
            this.TargetIB.TabStop = false;
            // 
            // splitContainerData
            // 
            this.splitContainerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerData.Location = new System.Drawing.Point(0, 0);
            this.splitContainerData.Name = "splitContainerData";
            this.splitContainerData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerData.Panel1
            // 
            this.splitContainerData.Panel1.Controls.Add(this.labelShotsInSeries);
            this.splitContainerData.Panel1.Controls.Add(this.numericShotsInSeries);
            this.splitContainerData.Panel1.Controls.Add(this.buttonRepairLast);
            this.splitContainerData.Panel1.Controls.Add(this.chckShowAll);
            this.splitContainerData.Panel1.Controls.Add(this.buttonClean);
            this.splitContainerData.Panel1.Controls.Add(this.buttonRemLast);
            // 
            // splitContainerData.Panel2
            // 
            this.splitContainerData.Panel2.Controls.Add(this.label4);
            this.splitContainerData.Panel2.Controls.Add(this.label2);
            this.splitContainerData.Panel2.Controls.Add(this.labelSeconds);
            this.splitContainerData.Panel2.Controls.Add(this.labelMinutes);
            this.splitContainerData.Panel2.Controls.Add(this.labelHours);
            this.splitContainerData.Panel2.Controls.Add(this.labelSum);
            this.splitContainerData.Panel2.Controls.Add(this.label3);
            this.splitContainerData.Panel2.Controls.Add(this.labSeries);
            this.splitContainerData.Panel2.Controls.Add(this.label1);
            this.splitContainerData.Panel2.Controls.Add(this.flPanelSeries);
            this.splitContainerData.Size = new System.Drawing.Size(783, 811);
            this.splitContainerData.SplitterDistance = 37;
            this.splitContainerData.TabIndex = 9;
            // 
            // labelShotsInSeries
            // 
            this.labelShotsInSeries.AutoSize = true;
            this.labelShotsInSeries.Location = new System.Drawing.Point(370, 13);
            this.labelShotsInSeries.Name = "labelShotsInSeries";
            this.labelShotsInSeries.Size = new System.Drawing.Size(92, 13);
            this.labelShotsInSeries.TabIndex = 6;
            this.labelShotsInSeries.Text = "No Shots in series";
            // 
            // numericShotsInSeries
            // 
            this.numericShotsInSeries.Location = new System.Drawing.Point(468, 10);
            this.numericShotsInSeries.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericShotsInSeries.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericShotsInSeries.Name = "numericShotsInSeries";
            this.numericShotsInSeries.Size = new System.Drawing.Size(48, 20);
            this.numericShotsInSeries.TabIndex = 5;
            this.numericShotsInSeries.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericShotsInSeries.ValueChanged += new System.EventHandler(this.numericShotsInSeries_ValueChanged);
            // 
            // buttonRepairLast
            // 
            this.buttonRepairLast.Location = new System.Drawing.Point(90, 7);
            this.buttonRepairLast.Name = "buttonRepairLast";
            this.buttonRepairLast.Size = new System.Drawing.Size(97, 23);
            this.buttonRepairLast.TabIndex = 4;
            this.buttonRepairLast.Text = "Popraw ostatni";
            this.buttonRepairLast.UseVisualStyleBackColor = true;
            this.buttonRepairLast.Click += new System.EventHandler(this.buttonRepairLast_Click);
            // 
            // chckShowAll
            // 
            this.chckShowAll.AutoSize = true;
            this.chckShowAll.Checked = true;
            this.chckShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckShowAll.Location = new System.Drawing.Point(633, 9);
            this.chckShowAll.Name = "chckShowAll";
            this.chckShowAll.Size = new System.Drawing.Size(138, 17);
            this.chckShowAll.TabIndex = 3;
            this.chckShowAll.Text = "Pokaż wszystkie strzały";
            this.chckShowAll.UseVisualStyleBackColor = true;
            this.chckShowAll.CheckedChanged += new System.EventHandler(this.chckShowAll_CheckedChanged);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(543, 7);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 1;
            this.buttonClean.Text = "Wyczyść";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonRemLast
            // 
            this.buttonRemLast.Location = new System.Drawing.Point(9, 7);
            this.buttonRemLast.Name = "buttonRemLast";
            this.buttonRemLast.Size = new System.Drawing.Size(75, 23);
            this.buttonRemLast.TabIndex = 2;
            this.buttonRemLast.Text = "Usuń ostatni";
            this.buttonRemLast.UseVisualStyleBackColor = true;
            this.buttonRemLast.Click += new System.EventHandler(this.buttonRemLast_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(74, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSeconds.Location = new System.Drawing.Point(85, 737);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(26, 17);
            this.labelSeconds.TabIndex = 7;
            this.labelSeconds.Text = "00";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinutes.Location = new System.Drawing.Point(52, 737);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(26, 17);
            this.labelMinutes.TabIndex = 6;
            this.labelMinutes.Text = "00";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHours.Location = new System.Drawing.Point(20, 737);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(26, 17);
            this.labelHours.TabIndex = 5;
            this.labelHours.Text = "00";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSum.Location = new System.Drawing.Point(667, 707);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 24);
            this.labelSum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(592, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma: ";
            // 
            // labSeries
            // 
            this.labSeries.AutoSize = true;
            this.labSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSeries.Location = new System.Drawing.Point(86, 707);
            this.labSeries.Name = "labSeries";
            this.labSeries.Size = new System.Drawing.Size(0, 24);
            this.labSeries.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serie: ";
            // 
            // flPanelSeries
            // 
            this.flPanelSeries.AutoScroll = true;
            this.flPanelSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.flPanelSeries.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelSeries.Location = new System.Drawing.Point(0, 0);
            this.flPanelSeries.Name = "flPanelSeries";
            this.flPanelSeries.Size = new System.Drawing.Size(783, 684);
            this.flPanelSeries.TabIndex = 0;
            this.flPanelSeries.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 811);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TargetIB)).EndInit();
            this.splitContainerData.Panel1.ResumeLayout(false);
            this.splitContainerData.Panel1.PerformLayout();
            this.splitContainerData.Panel2.ResumeLayout(false);
            this.splitContainerData.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData)).EndInit();
            this.splitContainerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericShotsInSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox TargetIB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonRemLast;
        private System.Windows.Forms.SplitContainer splitContainerData;
        private System.Windows.Forms.FlowLayoutPanel flPanelSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labSeries;
        private System.Windows.Forms.CheckBox chckShowAll;
        private System.Windows.Forms.Button buttonRepairLast;
        private System.Windows.Forms.Label labelShotsInSeries;
        private System.Windows.Forms.NumericUpDown numericShotsInSeries;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}