namespace Veterinaria
{
    partial class Vacunas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBoxVacuna = new System.Windows.Forms.TextBox();
            this.textBoxVeterinario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnID_Vermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(239, 247);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(100, 20);
            this.tbuscarpor.TabIndex = 47;
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.AllowUserToAddRows = false;
            this.dataGridViewAnimal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_Vermifugo,
            this.ColumnAnimal,
            this.ColumnNombre,
            this.ColumnNombre_Vacuna,
            this.ColumnVeterinario,
            this.ColumnFecha});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnimal.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAnimal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(0, 283);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnimal.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAnimal.Size = new System.Drawing.Size(553, 150);
            this.dataGridViewAnimal.TabIndex = 45;
            this.dataGridViewAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimal_CellContentClick);
            this.dataGridViewAnimal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAnimal_RowHeaderMouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre del Animal",
            "Nombre de la Vacuna",
            "Ultimos Vermifugos"});
            this.comboBox1.Location = new System.Drawing.Point(99, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Buscar por:";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(345, 245);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 44;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(240, 184);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 42;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(138, 184);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 41;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(34, 184);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 40;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBuscarDueño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAnimal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxVacuna);
            this.groupBox1.Controls.Add(this.textBoxVeterinario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 150);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vacuna";
            // 
            // bBuscarDueño
            // 
            this.bBuscarDueño.Location = new System.Drawing.Point(276, 31);
            this.bBuscarDueño.Name = "bBuscarDueño";
            this.bBuscarDueño.Size = new System.Drawing.Size(123, 19);
            this.bBuscarDueño.TabIndex = 30;
            this.bBuscarDueño.Text = "Buscar Animal";
            this.bBuscarDueño.UseVisualStyleBackColor = true;
            this.bBuscarDueño.Click += new System.EventHandler(this.bBuscarDueño_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Animal";
            // 
            // textBoxAnimal
            // 
            this.textBoxAnimal.Location = new System.Drawing.Point(133, 31);
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
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de Vacuna";
            // 
            // textBoxVacuna
            // 
            this.textBoxVacuna.Location = new System.Drawing.Point(133, 71);
            this.textBoxVacuna.Name = "textBoxVacuna";
            this.textBoxVacuna.Size = new System.Drawing.Size(137, 20);
            this.textBoxVacuna.TabIndex = 1;
            // 
            // textBoxVeterinario
            // 
            this.textBoxVeterinario.Location = new System.Drawing.Point(133, 109);
            this.textBoxVeterinario.Name = "textBoxVeterinario";
            this.textBoxVeterinario.Size = new System.Drawing.Size(137, 20);
            this.textBoxVeterinario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veterinario";
            // 
            // ColumnID_Vermifugo
            // 
            this.ColumnID_Vermifugo.DataPropertyName = "ID_vacunas";
            this.ColumnID_Vermifugo.HeaderText = "ID Vacuna";
            this.ColumnID_Vermifugo.Name = "ColumnID_Vermifugo";
            this.ColumnID_Vermifugo.ReadOnly = true;
            // 
            // ColumnAnimal
            // 
            this.ColumnAnimal.DataPropertyName = "ID_Animal";
            this.ColumnAnimal.HeaderText = "ID Animal";
            this.ColumnAnimal.Name = "ColumnAnimal";
            this.ColumnAnimal.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Nombre";
            this.ColumnNombre.HeaderText = "Nombre del Animal";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 140;
            // 
            // ColumnNombre_Vacuna
            // 
            this.ColumnNombre_Vacuna.DataPropertyName = "Nombre_Vacuna";
            this.ColumnNombre_Vacuna.HeaderText = "Nombre de la Vacuna";
            this.ColumnNombre_Vacuna.Name = "ColumnNombre_Vacuna";
            this.ColumnNombre_Vacuna.ReadOnly = true;
            this.ColumnNombre_Vacuna.Width = 140;
            // 
            // ColumnVeterinario
            // 
            this.ColumnVeterinario.DataPropertyName = "Veterinario";
            this.ColumnVeterinario.HeaderText = "Veterinario";
            this.ColumnVeterinario.Name = "ColumnVeterinario";
            this.ColumnVeterinario.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "Fecha";
            this.ColumnFecha.HeaderText = "Fecha de la Vacuna";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.Width = 130;
            // 
            // Vacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 433);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.dataGridViewAnimal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacunas";
            this.Load += new System.EventHandler(this.Vacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBoxVacuna;
        private System.Windows.Forms.TextBox textBoxVeterinario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Vermifugo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
    }
}