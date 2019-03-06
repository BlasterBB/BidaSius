namespace BidaSius
{
    partial class SeriesRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSerie = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labSerieTotal = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSerie
            // 
            this.dataGridViewSerie.AllowUserToAddRows = false;
            this.dataGridViewSerie.AllowUserToDeleteRows = false;
            this.dataGridViewSerie.AllowUserToResizeColumns = false;
            this.dataGridViewSerie.AllowUserToResizeRows = false;
            this.dataGridViewSerie.AutoGenerateColumns = false;
            this.dataGridViewSerie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSerie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.singleValueDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridViewSerie.DataSource = this.shotBindingSource;
            this.dataGridViewSerie.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSerie.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSerie.MultiSelect = false;
            this.dataGridViewSerie.Name = "dataGridViewSerie";
            this.dataGridViewSerie.ReadOnly = true;
            this.dataGridViewSerie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSerie.RowHeadersVisible = false;
            this.dataGridViewSerie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSerie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSerie.ShowCellErrors = false;
            this.dataGridViewSerie.ShowCellToolTips = false;
            this.dataGridViewSerie.ShowEditingIcon = false;
            this.dataGridViewSerie.Size = new System.Drawing.Size(256, 241);
            this.dataGridViewSerie.TabIndex = 0;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 50;
            // 
            // singleValueDataGridViewTextBoxColumn
            // 
            this.singleValueDataGridViewTextBoxColumn.DataPropertyName = "SingleValue";
            this.singleValueDataGridViewTextBoxColumn.HeaderText = "SingleValue";
            this.singleValueDataGridViewTextBoxColumn.Name = "singleValueDataGridViewTextBoxColumn";
            this.singleValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shotBindingSource
            // 
            this.shotBindingSource.DataSource = typeof(BidaSius.Shot);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seria: ";
            // 
            // labSerieTotal
            // 
            this.labSerieTotal.AutoSize = true;
            this.labSerieTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSerieTotal.Location = new System.Drawing.Point(78, 247);
            this.labSerieTotal.Name = "labSerieTotal";
            this.labSerieTotal.Size = new System.Drawing.Size(0, 20);
            this.labSerieTotal.TabIndex = 5;
            // 
            // imageBox1
            // 
            this.imageBox1.HideScrolls = false;
            this.imageBox1.Location = new System.Drawing.Point(265, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(276, 264);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // SeriesRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.labSerieTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSerie);
            this.Name = "SeriesRow";
            this.Size = new System.Drawing.Size(549, 272);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSerie;
        private System.Windows.Forms.BindingSource shotBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSerieTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singleValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
       
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}
