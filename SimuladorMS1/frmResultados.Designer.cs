namespace SimuladorMS1
{
    partial class frmResultados
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
            this.labelWq = new System.Windows.Forms.Label();
            this.labelLq = new System.Windows.Forms.Label();
            this.labelWs = new System.Windows.Forms.Label();
            this.labelLs = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelP0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWq
            // 
            this.labelWq.AutoSize = true;
            this.labelWq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWq.Location = new System.Drawing.Point(46, 43);
            this.labelWq.Name = "labelWq";
            this.labelWq.Size = new System.Drawing.Size(353, 25);
            this.labelWq.TabIndex = 0;
            this.labelWq.Text = "Tiempo de espera en la cola (Wq): ";
            // 
            // labelLq
            // 
            this.labelLq.AutoSize = true;
            this.labelLq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLq.Location = new System.Drawing.Point(46, 94);
            this.labelLq.Name = "labelLq";
            this.labelLq.Size = new System.Drawing.Size(370, 25);
            this.labelLq.TabIndex = 1;
            this.labelLq.Text = "Número de personas en la cola (Lq): ";
            // 
            // labelWs
            // 
            this.labelWs.AutoSize = true;
            this.labelWs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWs.Location = new System.Drawing.Point(46, 146);
            this.labelWs.Name = "labelWs";
            this.labelWs.Size = new System.Drawing.Size(386, 25);
            this.labelWs.TabIndex = 2;
            this.labelWs.Text = "Tiempo de espera en el sistema (Ws): ";
            // 
            // labelLs
            // 
            this.labelLs.AutoSize = true;
            this.labelLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLs.Location = new System.Drawing.Point(46, 193);
            this.labelLs.Name = "labelLs";
            this.labelLs.Size = new System.Drawing.Size(403, 25);
            this.labelLs.TabIndex = 3;
            this.labelLs.Text = "Número de personas en el sistema (Ls): ";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.Location = new System.Drawing.Point(46, 243);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(367, 25);
            this.labelP.TabIndex = 4;
            this.labelP.Text = "Probabilidad de uso del sistema (P): ";
            // 
            // labelP0
            // 
            this.labelP0.AutoSize = true;
            this.labelP0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP0.Location = new System.Drawing.Point(46, 291);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(384, 25);
            this.labelP0.TabIndex = 5;
            this.labelP0.Text = "Probabilidad de ocio del sistema P(0): ";
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 380);
            this.Controls.Add(this.labelP0);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelLs);
            this.Controls.Add(this.labelWs);
            this.Controls.Add(this.labelLq);
            this.Controls.Add(this.labelWq);
            this.Name = "frmResultados";
            this.Text = "Resultados del Modelo MM1";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWq;
        private System.Windows.Forms.Label labelLq;
        private System.Windows.Forms.Label labelWs;
        private System.Windows.Forms.Label labelLs;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelP0;
    }
}