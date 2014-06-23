namespace Veterinaria
{
    partial class ProductosConcept
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNO = new System.Windows.Forms.RadioButton();
            this.checkBoxSI = new System.Windows.Forms.RadioButton();
            this.ColumnID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(130, 38);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(138, 20);
            this.textBoxProducto.TabIndex = 0;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(130, 79);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(138, 20);
            this.textBoxPrecio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio RD$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rebajar del Inventario";
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(236, 286);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(100, 20);
            this.tbuscarpor.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_Producto,
            this.ColumnProducto,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnEstatus,
            this.ColumnFecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Nombre del Producto",
            "Ultimos Productos"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(104, 286);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 21;
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Buscar por:";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(342, 286);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 22;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(236, 234);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 20;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(136, 234);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 19;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(30, 234);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 18;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(130, 152);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(70, 20);
            this.textBoxCantidad.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxNO);
            this.groupBox1.Controls.Add(this.checkBoxSI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.textBoxProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 189);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // checkBoxNO
            // 
            this.checkBoxNO.AutoSize = true;
            this.checkBoxNO.Location = new System.Drawing.Point(202, 119);
            this.checkBoxNO.Name = "checkBoxNO";
            this.checkBoxNO.Size = new System.Drawing.Size(41, 17);
            this.checkBoxNO.TabIndex = 33;
            this.checkBoxNO.TabStop = true;
            this.checkBoxNO.Text = "NO";
            this.checkBoxNO.UseVisualStyleBackColor = true;
            this.checkBoxNO.CheckedChanged += new System.EventHandler(this.checkBoxNO_CheckedChanged);
            // 
            // checkBoxSI
            // 
            this.checkBoxSI.AutoSize = true;
            this.checkBoxSI.Location = new System.Drawing.Point(160, 119);
            this.checkBoxSI.Name = "checkBoxSI";
            this.checkBoxSI.Size = new System.Drawing.Size(35, 17);
            this.checkBoxSI.TabIndex = 32;
            this.checkBoxSI.TabStop = true;
            this.checkBoxSI.Text = "SI";
            this.checkBoxSI.UseVisualStyleBackColor = true;
            this.checkBoxSI.CheckedChanged += new System.EventHandler(this.checkBoxSI_CheckedChanged);
            // 
            // ColumnID_Producto
            // 
            this.ColumnID_Producto.DataPropertyName = "ID_Producto";
            this.ColumnID_Producto.HeaderText = "ID del Producto";
            this.ColumnID_Producto.Name = "ColumnID_Producto";
            this.ColumnID_Producto.ReadOnly = true;
            this.ColumnID_Producto.Width = 120;
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.DataPropertyName = "Producto";
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.DataPropertyName = "Precio";
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.DataPropertyName = "Cantidad_Existente";
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // ColumnEstatus
            // 
            this.ColumnEstatus.DataPropertyName = "Estatus";
            this.ColumnEstatus.HeaderText = "Estatus";
            this.ColumnEstatus.Name = "ColumnEstatus";
            this.ColumnEstatus.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "Fecha";
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ProductosConcept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bGuardar);
            this.Name = "ProductosConcept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosConcept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown textBoxCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkBoxNO;
        private System.Windows.Forms.RadioButton checkBoxSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
    }
}