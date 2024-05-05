namespace SimuladorMS1
{
    partial class AgregarProducto
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.textPC = new System.Windows.Forms.TextBox();
            this.textPO = new System.Windows.Forms.TextBox();
            this.textPV = new System.Windows.Forms.TextBox();
            this.textPG = new System.Windows.Forms.TextBox();
            this.textUtilidad = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio operativo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentaje de ganancia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Utilidad";
            // 
            // textProducto
            // 
            this.textProducto.Location = new System.Drawing.Point(226, 96);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(279, 22);
            this.textProducto.TabIndex = 6;
            // 
            // textPC
            // 
            this.textPC.Location = new System.Drawing.Point(226, 150);
            this.textPC.Name = "textPC";
            this.textPC.Size = new System.Drawing.Size(100, 22);
            this.textPC.TabIndex = 7;
            // 
            // textPO
            // 
            this.textPO.Location = new System.Drawing.Point(226, 206);
            this.textPO.Name = "textPO";
            this.textPO.Size = new System.Drawing.Size(100, 22);
            this.textPO.TabIndex = 8;
            // 
            // textPV
            // 
            this.textPV.Location = new System.Drawing.Point(226, 265);
            this.textPV.Name = "textPV";
            this.textPV.Size = new System.Drawing.Size(100, 22);
            this.textPV.TabIndex = 9;
            // 
            // textPG
            // 
            this.textPG.Location = new System.Drawing.Point(251, 326);
            this.textPG.Name = "textPG";
            this.textPG.Size = new System.Drawing.Size(100, 22);
            this.textPG.TabIndex = 10;
            // 
            // textUtilidad
            // 
            this.textUtilidad.Location = new System.Drawing.Point(226, 387);
            this.textUtilidad.Name = "textUtilidad";
            this.textUtilidad.Size = new System.Drawing.Size(100, 22);
            this.textUtilidad.TabIndex = 11;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(185, 464);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(114, 51);
            this.guardar.TabIndex = 12;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese la información del Producto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.textUtilidad);
            this.Controls.Add(this.textPG);
            this.Controls.Add(this.textPV);
            this.Controls.Add(this.textPO);
            this.Controls.Add(this.textPC);
            this.Controls.Add(this.textProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox textPC;
        private System.Windows.Forms.TextBox textPO;
        private System.Windows.Forms.TextBox textPV;
        private System.Windows.Forms.TextBox textPG;
        private System.Windows.Forms.TextBox textUtilidad;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}