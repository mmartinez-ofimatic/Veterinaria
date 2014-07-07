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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        Rol_Bus rolesClass = new Rol_Bus();
        DataGridViewRow row;
        bool selectModeRow = false;

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
               if (selectModeRow == false)
               {
                if (textBoxNombre.Text != "")
                {
                    if (radioButtonAdmin.Checked != false || radioButtonLSyE.Checked != false || radioButtonLyS.Checked != false || radioButtonLectura.Checked != false)
                    {
                        if ((MessageBox.Show("Desea guardar el nuevo registro?", "¿Guardar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                        {
                            int permisos;
                            if (radioButtonAdmin.Checked == true)
                            {
                                permisos = 1;
                            }
                            else if (radioButtonLSyE.Checked == true)
                            {
                                permisos = 2;
                            }
                            else if (radioButtonLyS.Checked == true)
                            {
                                permisos = 3;
                            }
                            else if (radioButtonLectura.Checked == true)
                            {
                                permisos = 4;
                            }
                            else
                            {
                                permisos = 0;
                            }


                            rolesClass.rol = textBoxNombre.Text;
                            rolesClass.permisos = permisos;

                            if (rolesClass.Guardar())
                            {

                                dataGridView1.DataSource = rolesClass.BuscarTodos();
                                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanText();
                                ActualizarGrid();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe especificar por lo menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CleanText();
            }
        }

        public void CleanText()
        {
            textBoxNombre.Clear();
            radioButtonAdmin.Checked = false;
            radioButtonLSyE.Checked = false;
            radioButtonLyS.Checked = false;
            radioButtonLectura.Checked = false;
            dataGridView1.DataSource = rolesClass.BuscarTodos();
        }

        public void ActualizarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rolesClass.BuscarTodos();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            try
            {

                if (row.Selected == true)
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (radioButtonAdmin.Checked != false || radioButtonLSyE.Checked != false || radioButtonLyS.Checked != false || radioButtonLectura.Checked != false)
                        {
                            if ((MessageBox.Show("Desea modificar este registro?", "¿Guardar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                            {
                                int permisos;
                                if (radioButtonAdmin.Checked == true)
                                {
                                    permisos = 1;
                                }
                                else if (radioButtonLSyE.Checked == true)
                                {
                                    permisos = 2;
                                }
                                else if (radioButtonLyS.Checked == true)
                                {
                                    permisos = 3;
                                }
                                else if (radioButtonLectura.Checked == true)
                                {
                                    permisos = 4;
                                }
                                else
                                {
                                    permisos = 0;
                                }

                                rolesClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                                rolesClass.rol = textBoxNombre.Text;
                                rolesClass.permisos = permisos;


                                if (rolesClass.Modificar(rolesClass.ID))
                                {
                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    ActualizarGrid();
                                    row.Selected = false;
                                    selectModeRow = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe especificar por lo menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Primero busque un rol y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanText();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            comboBoxBuscar.Text = row.Cells[0].Value.ToString();
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            int permisos = Convert.ToInt32(row.Cells[2].Value.ToString());

            if (permisos == 1)
            {
                radioButtonAdmin.Checked = true;
            }
            else if (permisos == 2)
            {
                radioButtonLSyE.Checked = true;
            }
            else if (permisos == 3)
            {
                radioButtonLyS.Checked = true;

            }
            else if (permisos == 4)
            {
                radioButtonLectura.Checked = true;
            }
            else
            {
                permisos = 0;
            }


            bGuardar.Enabled = false;
            selectModeRow = row.Selected;
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            try
            {

                if (row.Selected == true)
                {
                    // se valida que el id de la fila seleccionada sea igual que la del textbox

                    if (row.Cells[0].Value.ToString() != "")
                    {
                        rolesClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar este Rol?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (rolesClass.Borrar(rolesClass.ID))
                            {
                                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanText();
                                ActualizarGrid();
                                row.Selected = false;
                                selectModeRow = false;
                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("Seleccione un rol para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Primero busque un rol y seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBuscar.Text != "")
                {
                    if (tbuscarpor.Text != "")
                    {
                        if (comboBoxBuscar.Text == "ID del rol")
                        {

                            rolesClass.ID = Convert.ToInt32(tbuscarpor.Text);

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = rolesClass.BuscarxID(Convert.ToInt32(tbuscarpor.Text));

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este rol no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (comboBoxBuscar.Text == "Nombre del rol")
                        {
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = rolesClass.BuscarxNombre(tbuscarpor.Text);

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este rol no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Rol_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "Ultimos Clientes")
            //{
            //    //dataGridView1.AutoGenerateColumns = false;
            //    dataGridView1.DataSource = clienteLogic.BuscarUltimosClientes();
            //}
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick(sender, null);
        }


    }
}
