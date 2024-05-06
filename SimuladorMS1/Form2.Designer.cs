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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdSimuladorDataSet1 = new SimuladorMS1.bdSimuladorDataSet();
            this.agregarp = new System.Windows.Forms.Button();
            this.tb_productoTableAdapter = new SimuladorMS1.bdSimuladorDataSetTableAdapters.tb_productoTableAdapter();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciooperativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajegananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSimuladorDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1151, 652);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.agregarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarp.Location = new System.Drawing.Point(565, 700);
            this.agregarp.Name = "agregarp";
            this.agregarp.Size = new System.Drawing.Size(260, 65);
            this.agregarp.TabIndex = 2;
            this.agregarp.Text = "Agregar Producto";
            this.agregarp.UseVisualStyleBackColor = true;
            this.agregarp.Click += new System.EventHandler(this.agregarp_Click);
            // 
            // tb_productoTableAdapter
            // 
            this.tb_productoTableAdapter.ClearBeforeFill = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciocostoDataGridViewTextBoxColumn
            // 
            this.preciocostoDataGridViewTextBoxColumn.DataPropertyName = "precio_costo";
            this.preciocostoDataGridViewTextBoxColumn.HeaderText = "Precio Costo (Q)";
            this.preciocostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciocostoDataGridViewTextBoxColumn.Name = "preciocostoDataGridViewTextBoxColumn";
            this.preciocostoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciooperativoDataGridViewTextBoxColumn
            // 
            this.preciooperativoDataGridViewTextBoxColumn.DataPropertyName = "precio_operativo";
            this.preciooperativoDataGridViewTextBoxColumn.HeaderText = "Precio Operativo (Q)";
            this.preciooperativoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciooperativoDataGridViewTextBoxColumn.Name = "preciooperativoDataGridViewTextBoxColumn";
            this.preciooperativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioventaDataGridViewTextBoxColumn
            // 
            this.precioventaDataGridViewTextBoxColumn.DataPropertyName = "precio_venta";
            this.precioventaDataGridViewTextBoxColumn.HeaderText = "Precio Venta (Q)";
            this.precioventaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioventaDataGridViewTextBoxColumn.Name = "precioventaDataGridViewTextBoxColumn";
            this.precioventaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajegananciaDataGridViewTextBoxColumn
            // 
            this.porcentajegananciaDataGridViewTextBoxColumn.DataPropertyName = "porcentaje_ganancia";
            this.porcentajegananciaDataGridViewTextBoxColumn.HeaderText = "Porcentaje Ganancia";
            this.porcentajegananciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.porcentajegananciaDataGridViewTextBoxColumn.Name = "porcentajegananciaDataGridViewTextBoxColumn";
            this.porcentajegananciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilidadDataGridViewTextBoxColumn
            // 
            this.utilidadDataGridViewTextBoxColumn.DataPropertyName = "utilidad";
            this.utilidadDataGridViewTextBoxColumn.HeaderText = "Utilidad (Q)";
            this.utilidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilidadDataGridViewTextBoxColumn.Name = "utilidadDataGridViewTextBoxColumn";
            this.utilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1313, 924);
            this.Controls.Add(this.agregarp);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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