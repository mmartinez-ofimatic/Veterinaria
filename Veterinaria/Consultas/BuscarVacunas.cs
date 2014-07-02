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
    public partial class BuscarVacunas : Form
    {
        public BuscarVacunas()
        {
            InitializeComponent();
        }

        Vacunas_Bus vacunas= new Vacunas_Bus();
        
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

                            dataGridView1.DataSource = vacunas.BuscarxNombreAnimal(tbuscarpor.Text);
                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Animal no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (comboBoxBuscar.Text == "Nombre de la Vacuna")
                        {
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = vacunas.BuscarxNombre(tbuscarpor.Text);
                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Esta Vacuna no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (comboBoxBuscar.Text == "Ultimas Vacunas")
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = vacunas.BuscarUltimasVacunas();
            }
        }

        private void BuscarVacunas_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = vacunas.BuscarUltimasVacunas();
        }
    }
}
