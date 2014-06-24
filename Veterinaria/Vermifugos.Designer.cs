namespace Veterinaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVermifugo = new System.Windows.Forms.TextBox();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnID_Vermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(233, 308);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(100, 20);
            this.tbuscarpor.TabIndex = 38;
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.AllowUserToAddRows = false;
            this.dataGridViewAnimal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnimal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_Vermifugo,
            this.ColumnAnimal,
            this.ColumnVermifugo,
            this.ColumnResultados,
            this.ColumnFecha});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnimal.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewAnimal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(0, 376);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnimal.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewAnimal.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewAnimal.TabIndex = 36;
            this.dataGridViewAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimal_CellContentClick);
            this.dataGridViewAnimal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAnimal_RowHeaderMouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre del Animal",
            "Nombre del Vermifugo",
            "Ultimos Vermifugos"});
            this.comboBox1.Location = new System.Drawing.Point(101, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Buscar por:";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(339, 306);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 35;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(234, 241);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 33;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(139, 240);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 32;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(28, 241);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 31;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBuscarDueño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAnimal);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxVermifugo);
            this.groupBox1.Controls.Add(this.textBoxResultados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 198);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vermifugo";
            // 
            // bBuscarDueño
            // 
            this.bBuscarDueño.Location = new System.Drawing.Point(233, 31);
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
            this.textBoxAnimal.Location = new System.Drawing.Point(90, 31);
            this.textBoxAnimal.Name = "textBoxAnimal";
            this.textBoxAnimal.ReadOnly = true;
            this.textBoxAnimal.Size = new System.Drawing.Size(137, 20);
            this.textBoxAnimal.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha de Nacimiento";
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
            // ColumnID_Vermifugo
            // 
            this.ColumnID_Vermifugo.DataPropertyName = "ID_Vermifugo";
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
            // 
            // ColumnVermifugo
            // 
            this.ColumnVermifugo.DataPropertyName = "Vermifugo";
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
            this.ClientSize = new System.Drawing.Size(445, 526);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.dataGridViewAnimal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vermifugos";
            this.Text = "Vermifugos";
            this.Load += new System.EventHandler(this.Vermifugos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.DataGridView dataGridViewAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Vermifugo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVermifugo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVermifugo;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.Label label3;

    }
}