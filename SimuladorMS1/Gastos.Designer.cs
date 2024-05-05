namespace SimuladorMS1
{
    partial class Gastos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbgastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSimuladorDataSet = new SimuladorMS1.bdSimuladorDataSet();
            this.tb_gastoTableAdapter = new SimuladorMS1.bdSimuladorDataSetTableAdapters.tb_gastoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.idGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgastoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSimuladorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGastoDataGridViewTextBoxColumn,
            this.nombreGastoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.tipoGastoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbgastoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbgastoBindingSource
            // 
            this.tbgastoBindingSource.DataMember = "tb_gasto";
            this.tbgastoBindingSource.DataSource = this.bdSimuladorDataSet;
            // 
            // bdSimuladorDataSet
            // 
            this.bdSimuladorDataSet.DataSetName = "bdSimuladorDataSet";
            this.bdSimuladorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_gastoTableAdapter
            // 
            this.tb_gastoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Gasto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idGastoDataGridViewTextBoxColumn
            // 
            this.idGastoDataGridViewTextBoxColumn.DataPropertyName = "idGasto";
            this.idGastoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGastoDataGridViewTextBoxColumn.Name = "idGastoDataGridViewTextBoxColumn";
            this.idGastoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGastoDataGridViewTextBoxColumn.Visible = false;
            this.idGastoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreGastoDataGridViewTextBoxColumn
            // 
            this.nombreGastoDataGridViewTextBoxColumn.DataPropertyName = "nombreGasto";
            this.nombreGastoDataGridViewTextBoxColumn.HeaderText = "Gasto";
            this.nombreGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreGastoDataGridViewTextBoxColumn.Name = "nombreGastoDataGridViewTextBoxColumn";
            this.nombreGastoDataGridViewTextBoxColumn.Width = 150;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoGastoDataGridViewTextBoxColumn
            // 
            this.tipoGastoDataGridViewTextBoxColumn.DataPropertyName = "tipoGasto";
            this.tipoGastoDataGridViewTextBoxColumn.HeaderText = "Tipo de Gasto";
            this.tipoGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoGastoDataGridViewTextBoxColumn.Name = "tipoGastoDataGridViewTextBoxColumn";
            this.tipoGastoDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Información de los gastos en el sistema:";
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gastos";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.Gastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgastoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSimuladorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdSimuladorDataSet bdSimuladorDataSet;
        private System.Windows.Forms.BindingSource tbgastoBindingSource;
        private bdSimuladorDataSetTableAdapters.tb_gastoTableAdapter tb_gastoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}