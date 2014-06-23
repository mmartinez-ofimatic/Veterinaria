using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Datos;


namespace Veterinaria
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        Clientes_Bus clienteLogic = new Clientes_Bus();
        Validaciones validar = new Validaciones();
        bool selectModeRow = false;
        DataGridViewRow row; 

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
               {
                   if (textBoxNombre.Text != "")
                   {
                       if (validar.ValidateCedula(textBoxCedula.Text) || textBoxCedula.Text == "")
                       {
                           if (validar.ValidateNumeric(textBoxTelefono.Text) || textBoxTelefono.Text == "")
                           {
                               if (validar.ValidateNumeric(textBoxCelular.Text) || textBoxCelular.Text == "")
                               {

                                   Clientes_Bus.Cedula = textBoxCedula.Text;
                                    Clientes_Bus.Nombre = textBoxNombre.Text;
                                    Clientes_Bus.Telefono = textBoxTelefono.Text;
                                    Clientes_Bus.Celular = textBoxCelular.Text;
                                    Clientes_Bus.Direccion = textBoxDireccion.Text;

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
                                   MessageBox.Show("El campo Celular debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               }
                           }
                           else
                           {
                               MessageBox.Show("El campo Telefono debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }
                       }
                       else
                       {
                           MessageBox.Show("La cedula debe ser numerica y debe tener 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                   }
                   else
                   {
                       MessageBox.Show("Llene el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBoxCedula.Clear();
            textBoxCelular.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            selectModeRow = false;
            actualizarDatagrid();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == true)
                {
                    if (textBoxNombre.Text != "")
                    {

                        if (validar.ValidateCedula(textBoxCedula.Text) || textBoxCedula.Text == "")
                        {

                            if (validar.ValidateNumeric(textBoxTelefono.Text) || textBoxTelefono.Text == "")
                            {

                                if (validar.ValidateNumeric(textBoxCelular.Text) || textBoxCelular.Text == "")
                                {

                                    Clientes_Bus.Cedula = textBoxCedula.Text;
                                    Clientes_Bus.Nombre = textBoxNombre.Text;
                                    Clientes_Bus.Telefono = textBoxTelefono.Text;
                                    Clientes_Bus.Celular = textBoxCelular.Text;
                                    Clientes_Bus.Direccion = textBoxDireccion.Text;

                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este cliente?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (clienteLogic.Modificar(textBoxCedula.Text))
                                        {
                                            CleanText();
                                            MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo Celular debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo Telefono debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La Cedula debe ser numerica y debe tener 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Primero busque un cliente y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
             try
             {
                 if (selectModeRow == true)
                 {
                     // clientesclass.idcliente = Convert.ToInt32(row.Cells[0].Value.ToString());
                     if (clienteLogic.Borrar(textBoxCedula.Text))
                     {
                         CleanText();
                         MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ultimos Clientes")
            {
                //dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = clienteLogic.BuscarUltimosClientes();
            }
        }

        public void actualizarDatagrid()
        {
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clienteLogic.BuscarUltimosClientes();
            //dataGridView1.DataSource = clientesclass.BuscarTodos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxCedula.Text = row.Cells[0].Value.ToString();
            textBoxTelefono.Text = row.Cells[2].Value.ToString();
            textBoxCelular.Text = row.Cells[3].Value.ToString();
            textBoxDireccion.Text = row.Cells[4].Value.ToString();

            bGuardar.Enabled = false;
            Clientes_Bus.Cedula = row.Cells[0].Value.ToString();
            selectModeRow = row.Selected;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDatagrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                   if (comboBox1.Text == "Nombre")
                    {
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clienteLogic.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBox1.Text == "Cedula")
                    {
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clienteLogic.BuscarxCedula(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBox1.Text == "Ultimos Clientes")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = clienteLogic.BuscarUltimosClientes();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbuscarpor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }
    }
}
