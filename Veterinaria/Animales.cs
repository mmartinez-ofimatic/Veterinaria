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
    public partial class Animales : Form
    {
        public Animales()
        {
            InitializeComponent();
        }

        Dictionary<string, string> clienteKeyValue;
        Animales_Bus clienteLogic = new Animales_Bus();
        bool selectModeRow = false;

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
                {
                    if (textBoxCliente.Text != "")
                    {
                        if (textBoxNombre.Text != "")
                        {
                        if (textBoxRaza.Text!= "")
                        {
                            if (textBoxEspecie.Text != "")
                            {
                                if (textBoxSexo.Text != "")
                                {
                                    if (textBoxColor.Text != "")
                                    {

                                    Animales_Bus.Cedula = clienteKeyValue.Keys.First();
                                    Animales_Bus.Nombre = textBoxNombre.Text;
                                    Animales_Bus.Especie = textBoxEspecie.Text;
                                    Animales_Bus.Raza = textBoxRaza.Text;
                                    Animales_Bus.Sexo = textBoxSexo.Text;
                                    Animales_Bus.Color = textBoxColor.Text;
                                    Animales_Bus.Fecha_Nac = dateTimePicker1.Value;

                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (clienteLogic.Guardar())
                                        {
                                            CleanText();
                                            actualizarDatagrid();
                                            MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Llene el campo Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Llene el campo Sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Especie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Raza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un cliente seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void CleanText()
        {
            textBoxNombre.Clear();
            textBoxCliente.Clear();
            textBoxRaza.Clear();
            textBoxSexo.Clear();
            textBoxColor.Clear();
            textBoxEspecie.Clear();

            dateTimePicker1.Value = DateTime.Now;

            selectModeRow = false;
            actualizarDatagrid();
        }

        public void actualizarDatagrid()
        {
            dataGridViewAnimal.AutoGenerateColumns = false;
            dataGridViewAnimal.DataSource = clienteLogic.BuscarUltimosClientes();
            dataGridViewAnimal.DataSource = clientesclass.BuscarTodos();
        }

        private void bBuscarDueño_Click(object sender, EventArgs e)
        {
            Consultas.BuscarDueno buscar = new Consultas.BuscarDueno();
            buscar.ShowDialog(this);

            clienteKeyValue = new Dictionary<string, string>();
            clienteKeyValue.Add(buscar.cedula, buscar.cliente);
            textBoxCliente.Text = clienteKeyValue[buscar.cedula];
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Animales_Load(object sender, EventArgs e)
        {
            actualizarDatagrid();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
                {
                    if (textBoxCliente.Text != "")
                    {
                        if (textBoxNombre.Text != "")
                        {
                            if (textBoxRaza.Text != "")
                            {
                                if (textBoxEspecie.Text != "")
                                {
                                    if (textBoxSexo.Text != "")
                                    {
                                        if (textBoxColor.Text != "")
                                        {

                                            Animales_Bus.Cedula = clienteKeyValue.Keys.First();
                                            Animales_Bus.Nombre = textBoxNombre.Text;
                                            Animales_Bus.Especie = textBoxEspecie.Text;
                                            Animales_Bus.Raza = textBoxRaza.Text;
                                            Animales_Bus.Sexo = textBoxSexo.Text;
                                            Animales_Bus.Color = textBoxColor.Text;
                                            Animales_Bus.Fecha_Nac = dateTimePicker1.Value;


                                            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este cliente?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                if (clienteLogic.Modificar())
                                                {
                                                    CleanText();
                                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Llene el campo Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Llene el campo Sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Llene el campo Especie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Raza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un cliente seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        DataGridViewRow row; 
        private void dataGridViewAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridViewAnimal.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }
    }
}
