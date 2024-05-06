namespace SimuladorMS1
{
    partial class frmGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLineas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBarras
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBarras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBarras.Legends.Add(legend1);
            this.chartBarras.Location = new System.Drawing.Point(72, 57);
            this.chartBarras.Name = "chartBarras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBarras.Series.Add(series1);
            this.chartBarras.Size = new System.Drawing.Size(537, 455);
            this.chartBarras.TabIndex = 0;
            this.chartBarras.Text = "chart1";
            // 
            // chartLineas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLineas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLineas.Legends.Add(legend2);
            this.chartLineas.Location = new System.Drawing.Point(658, 57);
            this.chartLineas.Name = "chartLineas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLineas.Series.Add(series2);
            this.chartLineas.Size = new System.Drawing.Size(527, 455);
            this.chartLineas.TabIndex = 1;
            this.chartLineas.Text = "chart2";
            // 
            // frmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 565);
            this.Controls.Add(this.chartLineas);
            this.Controls.Add(this.chartBarras);
            this.Name = "frmGraficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficas";
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartLineas;
    }
}