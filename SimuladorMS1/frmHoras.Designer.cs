namespace SimuladorMS1
{
    partial class frmHoras
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
            this.dataHoras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoras
            // 
            this.dataHoras.AllowUserToAddRows = false;
            this.dataHoras.AllowUserToDeleteRows = false;
            this.dataHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoras.Location = new System.Drawing.Point(50, 54);
            this.dataHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataHoras.Name = "dataHoras";
            this.dataHoras.ReadOnly = true;
            this.dataHoras.RowHeadersWidth = 51;
            this.dataHoras.RowTemplate.Height = 24;
            this.dataHoras.Size = new System.Drawing.Size(495, 267);
            this.dataHoras.TabIndex = 0;
            this.dataHoras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoras_CellDoubleClick);
            // 
            // frmHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataHoras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horas";
            ((System.ComponentModel.ISupportInitialize)(this.dataHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataHoras;
    }
}