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
        Animales_Bus animaleLogic = new Animales_Bus();
        bool selectModeRow = false;
        Clientes_Bus clientesb = new Clientes_Bus();
        int idAnimal;
        DataGridViewRow row;
        public static int tiporol { get; set; }

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
                                        if (dateTimePicker1.Value.Date <= DateTime.Now.Date)
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
                                        if (animaleLogic.Guardar())
                                        {
                                            CleanText();
                                            actualizarDatagrid();
                                            MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                        }
                                        else
                                        {

                                            MessageBox.Show("La fecha de nacimiento debe ser menor a la del dia actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Seleccione un dueño", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un animal seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridViewAnimal.DataSource = animaleLogic.BuscarUltimosAnimales();
            
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
            row = dataGridViewAnimal.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBox1.Text == "Nombre del Animal")
                    {
                        dataGridViewAnimal.AutoGenerateColumns = false;

                        dataGridViewAnimal.DataSource = animaleLogic.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridViewAnimal.RowCount == 0)
                        {
                            MessageBox.Show("Esta mascota no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBox1.Text == "Cedula del Dueño")
                    {
                        dataGridViewAnimal.AutoGenerateColumns = false;

                        dataGridViewAnimal.DataSource = animaleLogic.BuscarxCedula(tbuscarpor.Text);
                        if (dataGridViewAnimal.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe o no tiene mascota!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBox1.Text == "Ultimos Clientes")
                    {
                        dataGridViewAnimal.AutoGenerateColumns = false;
                        dataGridViewAnimal.DataSource = animaleLogic.BuscarUltimosAnimales();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ultimos Animales")
            {
                dataGridViewAnimal.AutoGenerateColumns = false;
                dataGridViewAnimal.DataSource = animaleLogic.BuscarUltimosAnimales();
                
            }
        }

        private void Animales_Load(object sender, EventArgs e)
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
                bBorrar.Enabled = false;
                bModificar.Enabled = false;
            }
            else
            {
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


                                            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar esta mascota?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                if (animaleLogic.Modificar(idAnimal))
                                                {
                                                    CleanText();
                                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    bGuardar.Enabled = true;
                                                    row.Selected = false;
                                                    selectModeRow = false;
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
                

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridViewAnimal.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }

        private void dataGridViewAnimal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridViewAnimal.CurrentRow;

            idAnimal = Convert.ToInt32(row.Cells[0].Value.ToString());
            textBoxNombre.Text = row.Cells[1].Value.ToString();

           // Dictionary<string, string> clientesKeyValue = new Dictionary<string, string>();

            clienteKeyValue = new Dictionary<string, string>();
            clienteKeyValue = clientesb.BuscarxCedulaKey(row.Cells[2].Value.ToString());

            textBoxCliente.Text = clienteKeyValue.Values.First();

            textBoxRaza.Text = row.Cells[3].Value.ToString();
            textBoxEspecie.Text = row.Cells[4].Value.ToString();
            textBoxSexo.Text = row.Cells[5].Value.ToString();
            textBoxColor.Text = row.Cells[6].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
            

            bGuardar.Enabled = false;
            Clientes_Bus.Cedula = row.Cells[0].Value.ToString();
            selectModeRow = row.Selected;
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == true)
                {
                     DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar esta mascota?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (dialogResult == DialogResult.Yes)
                     {
                         if (animaleLogic.Borrar(idAnimal))
                         {
                             CleanText();
                             MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             row.Selected = false;
                             selectModeRow = false;
                         }
                     }
                }
                else
                {
                    MessageBox.Show("Primero busque un cliente y luego seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, trate de eliminar nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
 
    
    }
}
