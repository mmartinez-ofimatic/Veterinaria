﻿namespace Veterinaria
{
    partial class Vermifugos
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
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.dataGridViewAnimal = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuscarDueño = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVermifugo = new System.Windows.Forms.TextBox();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColumnID_Vermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(210, 12);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(100, 20);
            this.tbuscarpor.TabIndex = 38;
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
            this.ColumnID_Vermifugo,
            this.ColumnAnimal,
            this.ColumnNombre,
            this.ColumnVermifugo,
            this.ColumnResultados,
            this.ColumnFecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnimal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(3, 55);
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
            this.dataGridViewAnimal.RowHeadersVisible = false;
            this.dataGridViewAnimal.Size = new System.Drawing.Size(404, 209);
            this.dataGridViewAnimal.TabIndex = 36;
            this.dataGridViewAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimal_CellContentClick);
            this.dataGridViewAnimal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAnimal_RowHeaderMouseClick);
            this.dataGridViewAnimal.DoubleClick += new System.EventHandler(this.dataGridViewAnimal_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre de la Mascota",
            "Nombre del Vermifugo",
            "Ultimos Vermifugos"});
            this.comboBox1.Location = new System.Drawing.Point(70, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Buscar por:";
            // 
            // bBuscar
            // 
            this.bBuscar.BackgroundImage = global::Veterinaria.Properties.Resources.Find;
            this.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscar.Location = new System.Drawing.Point(316, 10);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(31, 23);
            this.bBuscar.TabIndex = 35;
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackgroundImage = global::Veterinaria.Properties.Resources.Error;
            this.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBorrar.Location = new System.Drawing.Point(414, 117);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(56, 48);
            this.bBorrar.TabIndex = 33;
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.BackgroundImage = global::Veterinaria.Properties.Resources._1878;
            this.bModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModificar.Location = new System.Drawing.Point(414, 63);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(56, 48);
            this.bModificar.TabIndex = 32;
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::Veterinaria.Properties.Resources.images;
            this.bGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGuardar.Location = new System.Drawing.Point(414, 9);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(56, 48);
            this.bGuardar.TabIndex = 31;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBuscarDueño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAnimal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxVermifugo);
            this.groupBox1.Controls.Add(this.textBoxResultados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 153);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vermifugo";
            // 
            // bBuscarDueño
            // 
            this.bBuscarDueño.BackgroundImage = global::Veterinaria.Properties.Resources.Find;
            this.bBuscarDueño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscarDueño.Location = new System.Drawing.Point(233, 27);
            this.bBuscarDueño.Name = "bBuscarDueño";
            this.bBuscarDueño.Size = new System.Drawing.Size(31, 27);
            this.bBuscarDueño.TabIndex = 30;
            this.bBuscarDueño.UseVisualStyleBackColor = true;
            this.bBuscarDueño.Click += new System.EventHandler(this.bBuscarDueño_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mascota";
            // 
            // textBoxAnimal
            // 
            this.textBoxAnimal.Location = new System.Drawing.Point(90, 31);
            this.textBoxAnimal.Name = "textBoxAnimal";
            this.textBoxAnimal.ReadOnly = true;
            this.textBoxAnimal.Size = new System.Drawing.Size(137, 20);
            this.textBoxAnimal.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vermifugo";
            // 
            // textBoxVermifugo
            // 
            this.textBoxVermifugo.Location = new System.Drawing.Point(90, 69);
            this.textBoxVermifugo.Name = "textBoxVermifugo";
            this.textBoxVermifugo.Size = new System.Drawing.Size(137, 20);
            this.textBoxVermifugo.TabIndex = 1;
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.Location = new System.Drawing.Point(90, 108);
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.Size = new System.Drawing.Size(137, 20);
            this.textBoxResultados.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultados";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 293);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Veterinaria.Properties.Resources.ANIMAL_PROYECT;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bGuardar);
            this.tabPage1.Controls.Add(this.bModificar);
            this.tabPage1.Controls.Add(this.bBorrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REGISTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Veterinaria.Properties.Resources.fondoo;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridViewAnimal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VERMIFUGO REGISTRADOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.bBuscar);
            this.panel1.Controls.Add(this.tbuscarpor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 43);
            this.panel1.TabIndex = 40;
            // 
            // ColumnID_Vermifugo
            // 
            this.ColumnID_Vermifugo.DataPropertyName = "ID_Vermifugos";
            this.ColumnID_Vermifugo.HeaderText = "ID Vermifugo";
            this.ColumnID_Vermifugo.Name = "ColumnID_Vermifugo";
            this.ColumnID_Vermifugo.ReadOnly = true;
            this.ColumnID_Vermifugo.Visible = false;
            // 
            // ColumnAnimal
            // 
            this.ColumnAnimal.DataPropertyName = "ID_Animal";
            this.ColumnAnimal.HeaderText = "ID Animal";
            this.ColumnAnimal.Name = "ColumnAnimal";
            this.ColumnAnimal.ReadOnly = true;
            this.ColumnAnimal.Visible = false;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Nombre";
            this.ColumnNombre.HeaderText = "Mascota";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnVermifugo
            // 
            this.ColumnVermifugo.DataPropertyName = "Vermifugo1";
            this.ColumnVermifugo.HeaderText = "Vermifugo";
            this.ColumnVermifugo.Name = "ColumnVermifugo";
            this.ColumnVermifugo.ReadOnly = true;
            // 
            // ColumnResultados
            // 
            this.ColumnResultados.DataPropertyName = "Resultados";
            this.ColumnResultados.HeaderText = "Resultados";
            this.ColumnResultados.Name = "ColumnResultados";
            this.ColumnResultados.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "Fecha";
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // Vermifugos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinaria.Properties.Resources.fondoplain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 293);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Vermifugos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vermifugos";
            this.Load += new System.EventHandler(this.Vermifugos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.DataGridView dataGridViewAnimal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bBuscarDueño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVermifugo;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Vermifugo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVermifugo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;

    }
}