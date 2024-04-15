namespace SimuladorMS1
{
    partial class Simulador
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
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dataGeneral = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductosCliente = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.dgvDetallesHora = new System.Windows.Forms.DataGridView();
            this.dgvDetallesProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(28, 84);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(332, 30);
            this.txtMedia.TabIndex = 0;
            this.txtMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedia_KeyPress);
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(1377, 129);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(157, 62);
            this.btnSimular.TabIndex = 1;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dataGeneral
            // 
            this.dataGeneral.AllowUserToAddRows = false;
            this.dataGeneral.AllowUserToDeleteRows = false;
            this.dataGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGeneral.Location = new System.Drawing.Point(95, 220);
            this.dataGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.dataGeneral.Name = "dataGeneral";
            this.dataGeneral.ReadOnly = true;
            this.dataGeneral.RowHeadersWidth = 51;
            this.dataGeneral.Size = new System.Drawing.Size(385, 295);
            this.dataGeneral.TabIndex = 2;
            this.dataGeneral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGeneral_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txtMedia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(95, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 145);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promedio de Clientes por Hora (µ):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio de Productos por Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.txtProductosCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(505, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 145);
            this.panel2.TabIndex = 4;
            // 
            // txtProductosCliente
            // 
            this.txtProductosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductosCliente.Location = new System.Drawing.Point(28, 83);
            this.txtProductosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductosCliente.Name = "txtProductosCliente";
            this.txtProductosCliente.Size = new System.Drawing.Size(396, 30);
            this.txtProductosCliente.TabIndex = 0;
            this.txtProductosCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductosCliente_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtHoras);
            this.panel3.Location = new System.Drawing.Point(989, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 145);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Horas a Simular:";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(28, 84);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(244, 30);
            this.txtHoras.TabIndex = 0;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            // 
            // dgvDetallesHora
            // 
            this.dgvDetallesHora.AllowUserToAddRows = false;
            this.dgvDetallesHora.AllowUserToDeleteRows = false;
            this.dgvDetallesHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesHora.Location = new System.Drawing.Point(515, 220);
            this.dgvDetallesHora.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetallesHora.Name = "dgvDetallesHora";
            this.dgvDetallesHora.ReadOnly = true;
            this.dgvDetallesHora.RowHeadersWidth = 51;
            this.dgvDetallesHora.Size = new System.Drawing.Size(385, 295);
            this.dgvDetallesHora.TabIndex = 6;
            this.dgvDetallesHora.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesHora_CellDoubleClick);
            // 
            // dgvDetallesProducto
            // 
            this.dgvDetallesProducto.AllowUserToAddRows = false;
            this.dgvDetallesProducto.AllowUserToDeleteRows = false;
            this.dgvDetallesProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesProducto.Location = new System.Drawing.Point(939, 220);
            this.dgvDetallesProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetallesProducto.Name = "dgvDetallesProducto";
            this.dgvDetallesProducto.ReadOnly = true;
            this.dgvDetallesProducto.RowHeadersWidth = 51;
            this.dgvDetallesProducto.Size = new System.Drawing.Size(385, 295);
            this.dgvDetallesProducto.TabIndex = 7;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1617, 1102);
            this.Controls.Add(this.dgvDetallesProducto);
            this.Controls.Add(this.dgvDetallesHora);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGeneral);
            this.Controls.Add(this.btnSimular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulador";
            this.Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGeneral)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductosCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoras;
        public System.Windows.Forms.DataGridView dataGeneral;
        public System.Windows.Forms.DataGridView dgvDetallesHora;
        public System.Windows.Forms.DataGridView dgvDetallesProducto;
    }
}