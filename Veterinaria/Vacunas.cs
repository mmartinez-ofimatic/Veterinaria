using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Veterinaria
{
    public partial class Vacunas : Form
    {
        public Vacunas()
        {
            InitializeComponent();
        }

        Vacunas_Bus vacunas = new Vacunas_Bus();
        Animales_Bus animales = new Animales_Bus();
        public static int tiporol { get; set; }
        Dictionary<int, string> vacunasKeyValue;
        bool selectModeRow = false;
        DataGridViewRow row;
        int idVacuna;

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
                {
                    if (textBoxAnimal.Text != "")
                    {
                        if (textBoxVacuna.Text != "")
                        {
                            if (textBoxVeterinario.Text != "")
                            {

                                Vacunas_Bus.ID_Animal = vacunasKeyValue.Keys.First();
                                Vacunas_Bus.Nombre_Vacuna = textBoxVacuna.Text;
                                Vacunas_Bus.Veterinario = textBoxVeterinario.Text;

                                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (vacunas.Guardar())
                                    {
                                        CleanText();
                                        actualizarDatagrid();
                                        MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Veterinario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Nombre de la Vacuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay una vacuna seleccionada, Deseleccionela para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bBuscarDueño_Click(object sender, EventArgs e)
        {
            Consultas.BuscarAnimales buscar = new Consultas.BuscarAnimales();
            buscar.ShowDialog();

            vacunasKeyValue = new Dictionary<int, string>();
            vacunasKeyValue.Add(buscar.idAnimal, buscar.nombre);
            textBoxAnimal.Text = vacunasKeyValue[buscar.idAnimal];
        }

        public void CleanText()
        {
            textBoxAnimal.Clear();
            textBoxVacuna.Clear();
            textBoxVeterinario.Clear();

            selectModeRow = false;
            actualizarDatagrid();
        }

        public void actualizarDatagrid()
        {
            dataGridViewAnimal.AutoGenerateColumns = false;
            dataGridViewAnimal.DataSource = vacunas.BuscarUltimasVacunas();
        }

        private void Vacunas_Load(object sender, EventArgs e)
        {
            Permisos();
            actualizarDatagrid();
        }

        public void Permisos()
        {
            if (tiporol == 1)
            {
                bBorrar.Enabled = true;
                bModificar.Enabled = true;
            }
            else if (tiporol == 2)
            {
                bBorrar.Enabled = true;
                bModificar.Enabled = true;
            }
            else if (tiporol == 3)
            {
                bBorrar.Enabled = false;
                bModificar.Enabled = false;
            }
            else if (tiporol == 4)
            {
                bGuardar.Enabled = false;
                bBorrar.Enabled = false;
                bModificar.Enabled = false;
            }
            else
            {
                bGuardar.Enabled = false;
                bBorrar.Enabled = false;
                bModificar.Enabled = false;
            }

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == true)
                {
                    if (textBoxAnimal.Text != "")
                    {
                        if (textBoxVacuna.Text != "")
                        {
                            if (textBoxVeterinario.Text != "")
                            {
                                Vacunas_Bus.ID_Animal = vacunasKeyValue.Keys.First();
                                Vacunas_Bus.Nombre_Vacuna = textBoxVacuna.Text;
                                Vacunas_Bus.Veterinario = textBoxVeterinario.Text;

                                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar esta vacuna?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (vacunas.Modificar(idVacuna))
                                    {
                                        CleanText();
                                        row.Selected = false;
                                        selectModeRow = false;
                                        MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        bGuardar.Enabled = true;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Veterinario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Nombre de la Vacuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewAnimal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridViewAnimal.CurrentRow;

            idVacuna = Convert.ToInt32(row.Cells[0].Value.ToString());

            vacunasKeyValue = new Dictionary<int, string>();
            vacunasKeyValue = animales.BuscarxAnimalKey(Convert.ToInt32(row.Cells[1].Value.ToString()));

            textBoxAnimal.Text = vacunasKeyValue.Values.First();

            textBoxVacuna.Text = row.Cells[3].Value.ToString();
            textBoxVeterinario.Text = row.Cells[4].Value.ToString();

            bGuardar.Enabled = false;
            idVacuna = Convert.ToInt32(row.Cells[0].Value.ToString());
            selectModeRow = row.Selected;
        }

        private void dataGridViewAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridViewAnimal.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == true)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar esta vacuna?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (vacunas.Borrar(idVacuna))
                        {
                            CleanText();
                            MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bGuardar.Enabled = true;
                            row.Selected = false;
                            selectModeRow = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Primero busque una vacuna y luego seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, trate de eliminar nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ultimas Vacunas")
            {
                dataGridViewAnimal.AutoGenerateColumns = false;
                dataGridViewAnimal.DataSource = vacunas.BuscarUltimasVacunas();

            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBox1.Text == "Nombre de la Mascota")
                    {
                        dataGridViewAnimal.AutoGenerateColumns = false;

                        dataGridViewAnimal.DataSource = vacunas.BuscarxNombreAnimal(tbuscarpor.Text);
                        if (dataGridViewAnimal.RowCount == 0)
                        {
                            MessageBox.Show("Esta Mascota no existe o no tiene vacunas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBox1.Text == "Nombre de la Vacuna")
                    {
                        dataGridViewAnimal.AutoGenerateColumns = false;

                        dataGridViewAnimal.DataSource = vacunas.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridViewAnimal.RowCount == 0)
                        {
                            MessageBox.Show("Esta vacuna no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewAnimal_DoubleClick(object sender, EventArgs e)
        {
            dataGridViewAnimal_CellContentClick(sender, null);
        }


    }
}
