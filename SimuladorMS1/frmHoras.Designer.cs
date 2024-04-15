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
            this.dataHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoras.Location = new System.Drawing.Point(67, 66);
            this.dataHoras.Name = "dataHoras";
            this.dataHoras.ReadOnly = true;
            this.dataHoras.RowHeadersWidth = 51;
            this.dataHoras.RowTemplate.Height = 24;
            this.dataHoras.Size = new System.Drawing.Size(660, 329);
            this.dataHoras.TabIndex = 0;
            this.dataHoras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoras_CellDoubleClick);
            // 
            // frmHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataHoras);
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