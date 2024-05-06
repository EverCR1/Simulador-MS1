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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio operativo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentaje de ganancia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Utilidad:";
            // 
            // textProducto
            // 
            this.textProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducto.Location = new System.Drawing.Point(357, 114);
            this.textProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(279, 30);
            this.textProducto.TabIndex = 6;
            this.textProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProducto_KeyPress);
            // 
            // textPC
            // 
            this.textPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPC.Location = new System.Drawing.Point(357, 161);
            this.textPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPC.Name = "textPC";
            this.textPC.Size = new System.Drawing.Size(279, 30);
            this.textPC.TabIndex = 7;
            this.textPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPC_KeyPress_1);
            // 
            // textPO
            // 
            this.textPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPO.Location = new System.Drawing.Point(357, 224);
            this.textPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPO.Name = "textPO";
            this.textPO.Size = new System.Drawing.Size(279, 30);
            this.textPO.TabIndex = 8;
            this.textPO.TextChanged += new System.EventHandler(this.textPO_TextChanged);
            this.textPO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPO_KeyPress);
            // 
            // textPV
            // 
            this.textPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPV.Location = new System.Drawing.Point(357, 283);
            this.textPV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPV.Name = "textPV";
            this.textPV.Size = new System.Drawing.Size(279, 30);
            this.textPV.TabIndex = 9;
            this.textPV.TextChanged += new System.EventHandler(this.textPV_TextChanged);
            this.textPV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPV_KeyPress);
            // 
            // textPG
            // 
            this.textPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPG.Location = new System.Drawing.Point(357, 335);
            this.textPG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPG.Name = "textPG";
            this.textPG.ReadOnly = true;
            this.textPG.Size = new System.Drawing.Size(279, 30);
            this.textPG.TabIndex = 10;
            // 
            // textUtilidad
            // 
            this.textUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUtilidad.Location = new System.Drawing.Point(357, 398);
            this.textUtilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUtilidad.Name = "textUtilidad";
            this.textUtilidad.ReadOnly = true;
            this.textUtilidad.Size = new System.Drawing.Size(279, 30);
            this.textUtilidad.TabIndex = 11;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(229, 513);
            this.guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(140, 62);
            this.guardar.TabIndex = 12;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(435, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese la información del Producto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 513);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 619);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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