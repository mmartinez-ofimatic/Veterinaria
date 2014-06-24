using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Veterinaria.Consultas
{
    public partial class BuscarAnimales : Form
    {
        public BuscarAnimales()
        {
            InitializeComponent();
        }


        Animales_Bus animal = new Animales_Bus();

        public int idAnimal { get; set; }
        public string nombre { get; set; }
            
        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBuscar.Text != "")
                {
                    if (tbuscarpor.Text != "")
                    {
                        if (comboBoxBuscar.Text == "Nombre del Animal")
                        {
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = animal.BuscarxNombre(tbuscarpor.Text);
                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Animal no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (comboBoxBuscar.Text == "Cedula del Dueño")
                        {
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = animal.BuscarxCedula(tbuscarpor.Text);
                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("LLene el campo de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Elija la opcion de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text == "Ultimos Animales")
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = animal.BuscarUltimosAnimales();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            nombre = row.Cells[2].Value.ToString();
            idAnimal = Convert.ToInt32(row.Cells[0].Value.ToString());
            this.Close(); 
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            dataGridView1_RowHeaderMouseClick(sender, null);
        }

        private void BuscarAnimales_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = animal.BuscarUltimosAnimales();
        }
    }
}
