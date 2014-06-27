namespace Veterinaria
{
    partial class Rol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonLSyE = new System.Windows.Forms.RadioButton();
            this.radioButtonLyS = new System.Windows.Forms.RadioButton();
            this.radioButtonLectura = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPermisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButtonLSyE);
            this.groupBox2.Controls.Add(this.radioButtonLyS);
            this.groupBox2.Controls.Add(this.radioButtonLectura);
            this.groupBox2.Controls.Add(this.radioButtonAdmin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 175);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(116, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 21);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre del Rol";
            // 
            // radioButtonLSyE
            // 
            this.radioButtonLSyE.AutoSize = true;
            this.radioButtonLSyE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLSyE.Location = new System.Drawing.Point(22, 101);
            this.radioButtonLSyE.Name = "radioButtonLSyE";
            this.radioButtonLSyE.Size = new System.Drawing.Size(243, 19);
            this.radioButtonLSyE.TabIndex = 3;
            this.radioButtonLSyE.TabStop = true;
            this.radioButtonLSyE.Text = "Permiso de Lectura, Escritura y Eliminar";
            this.radioButtonLSyE.UseVisualStyleBackColor = true;
            // 
            // radioButtonLyS
            // 
            this.radioButtonLyS.AutoSize = true;
            this.radioButtonLyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLyS.Location = new System.Drawing.Point(22, 126);
            this.radioButtonLyS.Name = "radioButtonLyS";
            this.radioButtonLyS.Size = new System.Drawing.Size(191, 19);
            this.radioButtonLyS.TabIndex = 3;
            this.radioButtonLyS.TabStop = true;
            this.radioButtonLyS.Text = "Permiso de Lectura y Escritura";
            this.radioButtonLyS.UseVisualStyleBackColor = true;
            // 
            // radioButtonLectura
            // 
            this.radioButtonLectura.AutoSize = true;
            this.radioButtonLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLectura.Location = new System.Drawing.Point(22, 149);
            this.radioButtonLectura.Name = "radioButtonLectura";
            this.radioButtonLectura.Size = new System.Drawing.Size(132, 19);
            this.radioButtonLectura.TabIndex = 4;
            this.radioButtonLectura.TabStop = true;
            this.radioButtonLectura.Text = "Permiso de Lectura";
            this.radioButtonLectura.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(22, 78);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(167, 19);
            this.radioButtonAdmin.TabIndex = 2;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Permiso de Administrador";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuscarpor.Location = new System.Drawing.Point(185, 278);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(80, 21);
            this.tbuscarpor.TabIndex = 50;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "ID del rol",
            "Nombre del rol"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(67, 277);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(112, 23);
            this.comboBoxBuscar.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 52;
            this.label14.Text = "Buscar por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDProducto,
            this.ColumnExistencia,
            this.ColumnPermisos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(362, 101);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ColumnIDProducto
            // 
            this.ColumnIDProducto.DataPropertyName = "ID_Rol";
            this.ColumnIDProducto.HeaderText = "ID del Rol";
            this.ColumnIDProducto.Name = "ColumnIDProducto";
            this.ColumnIDProducto.ReadOnly = true;
            this.ColumnIDProducto.Width = 108;
            // 
            // ColumnExistencia
            // 
            this.ColumnExistencia.DataPropertyName = "Rol";
            this.ColumnExistencia.HeaderText = "Nombre del Rol";
            this.ColumnExistencia.Name = "ColumnExistencia";
            this.ColumnExistencia.ReadOnly = true;
            this.ColumnExistencia.Width = 110;
            // 
            // ColumnPermisos
            // 
            this.ColumnPermisos.DataPropertyName = "Permisos";
            this.ColumnPermisos.HeaderText = "Permisos";
            this.ColumnPermisos.Name = "ColumnPermisos";
            this.ColumnPermisos.ReadOnly = true;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(28, 220);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 54;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(122, 220);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 55;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(216, 220);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 56;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(271, 278);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 57;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 420);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rol";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.Rol_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonLSyE;
        private System.Windows.Forms.RadioButton radioButtonLyS;
        private System.Windows.Forms.RadioButton radioButtonLectura;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPermisos;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bBuscar;
    }
}