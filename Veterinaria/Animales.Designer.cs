﻿namespace Veterinaria
{
    partial class Animales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animales));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuscarDueño = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.dataGridViewAnimal = new System.Windows.Forms.DataGridView();
            this.ColumnID_Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.BackgroundImage = global::Veterinaria.Properties.Resources.ANIMAL_PROYECT;
            this.groupBox1.Controls.Add(this.bBuscarDueño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCliente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxSexo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxRaza);
            this.groupBox1.Controls.Add(this.textBoxEspecie);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 198);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANIMALES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bBuscarDueño
            // 
            this.bBuscarDueño.BackgroundImage = global::Veterinaria.Properties.Resources.Find;
            this.bBuscarDueño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscarDueño.Location = new System.Drawing.Point(237, 24);
            this.bBuscarDueño.Name = "bBuscarDueño";
            this.bBuscarDueño.Size = new System.Drawing.Size(36, 31);
            this.bBuscarDueño.TabIndex = 30;
            this.bBuscarDueño.UseVisualStyleBackColor = true;
            this.bBuscarDueño.Click += new System.EventHandler(this.bBuscarDueño_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dueño";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(90, 31);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(137, 20);
            this.textBoxCliente.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(310, 67);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(135, 20);
            this.textBoxSexo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(248, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(248, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(90, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(137, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(90, 108);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(137, 20);
            this.textBoxRaza.TabIndex = 3;
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Location = new System.Drawing.Point(90, 146);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(137, 20);
            this.textBoxEspecie.TabIndex = 4;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(310, 105);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(135, 20);
            this.textBoxColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Especie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(248, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color";
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(197, 14);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(100, 20);
            this.tbuscarpor.TabIndex = 29;
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.AllowUserToAddRows = false;
            this.dataGridViewAnimal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_Animal,
            this.ColumnNombre,
            this.ColumnCedula,
            this.ColumnRaza,
            this.ColumnEspecie,
            this.ColumnSexo,
            this.ColumnColor,
            this.ColumnFecha_Nac});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnimal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnimal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAnimal.Size = new System.Drawing.Size(561, 156);
            this.dataGridViewAnimal.TabIndex = 27;
            this.dataGridViewAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimal_CellContentClick);
            this.dataGridViewAnimal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAnimal_RowHeaderMouseClick);
            this.dataGridViewAnimal.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ColumnID_Animal
            // 
            this.ColumnID_Animal.DataPropertyName = "ID_Animal";
            this.ColumnID_Animal.HeaderText = "ID Animal";
            this.ColumnID_Animal.Name = "ColumnID_Animal";
            this.ColumnID_Animal.ReadOnly = true;
            this.ColumnID_Animal.Visible = false;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Nombre";
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnCedula
            // 
            this.ColumnCedula.DataPropertyName = "Cedula";
            this.ColumnCedula.HeaderText = "Cedula";
            this.ColumnCedula.Name = "ColumnCedula";
            this.ColumnCedula.ReadOnly = true;
            // 
            // ColumnRaza
            // 
            this.ColumnRaza.DataPropertyName = "Raza";
            this.ColumnRaza.HeaderText = "Raza";
            this.ColumnRaza.Name = "ColumnRaza";
            this.ColumnRaza.ReadOnly = true;
            // 
            // ColumnEspecie
            // 
            this.ColumnEspecie.DataPropertyName = "Especie";
            this.ColumnEspecie.HeaderText = "Especie";
            this.ColumnEspecie.Name = "ColumnEspecie";
            this.ColumnEspecie.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.DataPropertyName = "Sexo";
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnColor
            // 
            this.ColumnColor.DataPropertyName = "Color";
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.ReadOnly = true;
            // 
            // ColumnFecha_Nac
            // 
            this.ColumnFecha_Nac.DataPropertyName = "Fecha_Nac";
            this.ColumnFecha_Nac.HeaderText = "Fecha_Nac";
            this.ColumnFecha_Nac.Name = "ColumnFecha_Nac";
            this.ColumnFecha_Nac.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre del Animal",
            "Cedula del Dueño",
            "Ultimos Animales"});
            this.comboBox1.Location = new System.Drawing.Point(70, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Buscar por:";
            // 
            // bBuscar
            // 
            this.bBuscar.BackgroundImage = global::Veterinaria.Properties.Resources.Find;
            this.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscar.Location = new System.Drawing.Point(308, 8);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(39, 29);
            this.bBuscar.TabIndex = 26;
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackgroundImage = global::Veterinaria.Properties.Resources.Error;
            this.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBorrar.Location = new System.Drawing.Point(503, 140);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(61, 54);
            this.bBorrar.TabIndex = 24;
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.BackgroundImage = global::Veterinaria.Properties.Resources._18781;
            this.bModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModificar.Location = new System.Drawing.Point(503, 79);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(61, 54);
            this.bModificar.TabIndex = 23;
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::Veterinaria.Properties.Resources.images;
            this.bGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGuardar.Location = new System.Drawing.Point(503, 18);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(61, 54);
            this.bGuardar.TabIndex = 22;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 245);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bBorrar);
            this.tabPage1.Controls.Add(this.bGuardar);
            this.tabPage1.Controls.Add(this.bModificar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REGISTRO DE ANIMALES";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(3, 276);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(578, 231);
            this.tabControl2.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.dataGridViewAnimal);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.bBuscar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbuscarpor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 205);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "ANIMALES REGISTRADOS";
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Veterinaria.Properties.Resources.fondoplain;
            this.ClientSize = new System.Drawing.Size(584, 506);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Animales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE ANIMALES";
            this.Load += new System.EventHandler(this.Animales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.TextBox textBoxEspecie;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.DataGridView dataGridViewAnimal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bBuscarDueño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha_Nac;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}