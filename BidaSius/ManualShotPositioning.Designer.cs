namespace BidaSius
{
    partial class ManualShotPositioning
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
            this.pictureBTarget = new System.Windows.Forms.PictureBox();
            this.labelValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBTarget
            // 
            this.pictureBTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBTarget.Location = new System.Drawing.Point(0, 0);
            this.pictureBTarget.Name = "pictureBTarget";
            this.pictureBTarget.Size = new System.Drawing.Size(442, 416);
            this.pictureBTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBTarget.TabIndex = 0;
            this.pictureBTarget.TabStop = false;
            this.pictureBTarget.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBTarget_Paint);
            this.pictureBTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBackground_MouseDown);
            this.pictureBTarget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBackground_MouseMove);
            this.pictureBTarget.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBackground_MouseUp);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.BackColor = System.Drawing.Color.Transparent;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValue.Location = new System.Drawing.Point(72, 481);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(0, 73);
            this.labelValue.TabIndex = 1;
            // 
            // ManualShotPositioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 416);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.pictureBTarget);
            this.Name = "ManualShotPositioning";
            this.Text = "ManualShotPositioning";
            this.Load += new System.EventHandler(this.ManualShotPositioning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBTarget;
        private System.Windows.Forms.Label labelValue;
    }
}