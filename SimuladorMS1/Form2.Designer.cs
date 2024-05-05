namespace SimuladorMS1
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciooperativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajegananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSimuladorDataSet1 = new SimuladorMS1.bdSimuladorDataSet();
            this.agregarp = new System.Windows.Forms.Button();
            this.tb_productoTableAdapter = new SimuladorMS1.bdSimuladorDataSetTableAdapters.tb_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSimuladorDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.preciocostoDataGridViewTextBoxColumn,
            this.preciooperativoDataGridViewTextBoxColumn,
            this.precioventaDataGridViewTextBoxColumn,
            this.porcentajegananciaDataGridViewTextBoxColumn,
            this.utilidadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tbproductoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(72, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(920, 487);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Visible = false;
            this.idProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // preciocostoDataGridViewTextBoxColumn
            // 
            this.preciocostoDataGridViewTextBoxColumn.DataPropertyName = "precio_costo";
            this.preciocostoDataGridViewTextBoxColumn.HeaderText = "Precio Costo";
            this.preciocostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciocostoDataGridViewTextBoxColumn.Name = "preciocostoDataGridViewTextBoxColumn";
            this.preciocostoDataGridViewTextBoxColumn.Width = 125;
            // 
            // preciooperativoDataGridViewTextBoxColumn
            // 
            this.preciooperativoDataGridViewTextBoxColumn.DataPropertyName = "precio_operativo";
            this.preciooperativoDataGridViewTextBoxColumn.HeaderText = "Precio Operativo";
            this.preciooperativoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciooperativoDataGridViewTextBoxColumn.Name = "preciooperativoDataGridViewTextBoxColumn";
            this.preciooperativoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioventaDataGridViewTextBoxColumn
            // 
            this.precioventaDataGridViewTextBoxColumn.DataPropertyName = "precio_venta";
            this.precioventaDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            this.precioventaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioventaDataGridViewTextBoxColumn.Name = "precioventaDataGridViewTextBoxColumn";
            this.precioventaDataGridViewTextBoxColumn.Width = 125;
            // 
            // porcentajegananciaDataGridViewTextBoxColumn
            // 
            this.porcentajegananciaDataGridViewTextBoxColumn.DataPropertyName = "porcentaje_ganancia";
            this.porcentajegananciaDataGridViewTextBoxColumn.HeaderText = "Porcentaje Ganancia";
            this.porcentajegananciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.porcentajegananciaDataGridViewTextBoxColumn.Name = "porcentajegananciaDataGridViewTextBoxColumn";
            this.porcentajegananciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // utilidadDataGridViewTextBoxColumn
            // 
            this.utilidadDataGridViewTextBoxColumn.DataPropertyName = "utilidad";
            this.utilidadDataGridViewTextBoxColumn.HeaderText = "Utilidad";
            this.utilidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilidadDataGridViewTextBoxColumn.Name = "utilidadDataGridViewTextBoxColumn";
            this.utilidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbproductoBindingSource
            // 
            this.tbproductoBindingSource.DataMember = "tb_producto";
            this.tbproductoBindingSource.DataSource = this.bdSimuladorDataSet1;
            // 
            // bdSimuladorDataSet1
            // 
            this.bdSimuladorDataSet1.DataSetName = "bdSimuladorDataSet";
            this.bdSimuladorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agregarp
            // 
            this.agregarp.Location = new System.Drawing.Point(461, 505);
            this.agregarp.Name = "agregarp";
            this.agregarp.Size = new System.Drawing.Size(171, 64);
            this.agregarp.TabIndex = 2;
            this.agregarp.Text = "Agregar Producto";
            this.agregarp.UseVisualStyleBackColor = true;
            this.agregarp.Click += new System.EventHandler(this.agregarp_Click);
            // 
            // tb_productoTableAdapter
            // 
            this.tb_productoTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 703);
            this.Controls.Add(this.agregarp);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSimuladorDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bdSimuladorDataSet bdSimuladorDataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tbproductoBindingSource;
        private bdSimuladorDataSetTableAdapters.tb_productoTableAdapter tb_productoTableAdapter;
        private System.Windows.Forms.Button agregarp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciooperativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajegananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadDataGridViewTextBoxColumn;
    }
}