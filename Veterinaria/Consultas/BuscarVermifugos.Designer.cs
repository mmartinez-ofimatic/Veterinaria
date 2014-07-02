namespace Veterinaria.Consultas
{
    partial class BuscarVermifugos
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIDVermifugos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID_Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreAni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(308, 18);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 57;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(201, 21);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(100, 20);
            this.tbuscarpor.TabIndex = 56;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Nombre del Animal",
            "Nombre del Vermifugo",
            "Ultimas Vermifugos"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(74, 21);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 55;
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(10, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Buscar por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDVermifugos,
            this.ColumnID_Animal,
            this.ColumnNombreAni,
            this.ColumnNombre,
            this.ColumnResultado,
            this.ColumnFecha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 187);
            this.dataGridView1.TabIndex = 53;
            // 
            // ColumnIDVermifugos
            // 
            this.ColumnIDVermifugos.DataPropertyName = "ID_Vermifugos";
            this.ColumnIDVermifugos.HeaderText = "ID_Vermifugos";
            this.ColumnIDVermifugos.Name = "ColumnIDVermifugos";
            this.ColumnIDVermifugos.ReadOnly = true;
            this.ColumnIDVermifugos.Visible = false;
            // 
            // ColumnID_Animal
            // 
            this.ColumnID_Animal.DataPropertyName = "ID_Animal";
            this.ColumnID_Animal.HeaderText = "ID del Animal";
            this.ColumnID_Animal.Name = "ColumnID_Animal";
            this.ColumnID_Animal.ReadOnly = true;
            // 
            // ColumnNombreAni
            // 
            this.ColumnNombreAni.DataPropertyName = "Nombre";
            this.ColumnNombreAni.HeaderText = "Nombre del Animal";
            this.ColumnNombreAni.Name = "ColumnNombreAni";
            this.ColumnNombreAni.ReadOnly = true;
            this.ColumnNombreAni.Width = 130;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Vermifugo1";
            this.ColumnNombre.HeaderText = "Nombre del Vermifugo";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 160;
            // 
            // ColumnResultado
            // 
            this.ColumnResultado.DataPropertyName = "Resultados";
            this.ColumnResultado.HeaderText = "Resultado";
            this.ColumnResultado.Name = "ColumnResultado";
            this.ColumnResultado.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "Fecha";
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // BuscarVermifugos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 251);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarVermifugos";
            this.Text = "BuscarVermifugos";
            this.Load += new System.EventHandler(this.BuscarVermifugos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDVermifugos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreAni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
    }
}