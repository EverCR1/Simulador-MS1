namespace SimuladorMS1
{
    partial class AgregarGasto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textGasto = new System.Windows.Forms.TextBox();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la información de nuevo Gasto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Gasto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Gasto:";
            // 
            // textGasto
            // 
            this.textGasto.Location = new System.Drawing.Point(217, 127);
            this.textGasto.Name = "textGasto";
            this.textGasto.Size = new System.Drawing.Size(100, 22);
            this.textGasto.TabIndex = 4;
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(217, 184);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(100, 22);
            this.textMonto.TabIndex = 5;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(217, 245);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(100, 22);
            this.textTipo.TabIndex = 6;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(281, 354);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(124, 49);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(429, 354);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(127, 49);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // AgregarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textMonto);
            this.Controls.Add(this.textGasto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarGasto";
            this.Text = "Agregar Gasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textGasto;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button cancelar;
    }
}