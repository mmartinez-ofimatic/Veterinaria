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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        Usuarios_Bus usuarioClass = new Usuarios_Bus();
        DataGridViewRow row;
        bool selectModeRow = false;
        int id;

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxContrasena.Text != "")
                        {
                            if (textBoxRcontrasena.Text != "")
                            {
                                if (textBoxContrasena.Text == textBoxRcontrasena.Text)
                                {
                                    if (comboBoxRol.Text != "")
                                    {
                                        usuarioClass.nomusuario = textBoxNombre.Text;
                                        usuarioClass.contrasena = textBoxContrasena.Text;
                                        usuarioClass.IDrol = Convert.ToInt32(comboBoxRol.SelectedValue);

                                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            if (usuarioClass.Guardar())
                                            {
                                                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                CleanText();
                                                ActualizarGrid();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La contraseña deben ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Repita la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Hay un usuario seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanText();
            }
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text == "Todos los usuarios")
            {
                //dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = usuarioClass.BuscarTodos();
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Rol_Bus roles = new Rol_Bus();
            comboBoxRol.DataSource = roles.BuscarTodos();
            comboBoxRol.DisplayMember = "Rol";
            comboBoxRol.ValueMember = "ID_Rol";
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = usuarioClass.BuscarTodos();
        }

        public void CleanText()
        {
            textBoxNombre.Clear();
            textBoxContrasena.Clear();
            textBoxRcontrasena.Clear();
            comboBoxRol.SelectedIndex = 0;
            tbuscarpor.Clear();
            dataGridView1.ClearSelection();
            id = 0;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (row.Selected == true)
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxContrasena.Text != "")
                        {
                            if (textBoxRcontrasena.Text != "")
                            {
                                if (textBoxContrasena.Text == textBoxRcontrasena.Text)
                                {
                                    if (comboBoxRol.Text != "")
                                    {
                                        if (id > 0)
                                        {
                                            //UsuarioInv.IDusuario = id;
                                            usuarioClass.nomusuario = textBoxNombre.Text;
                                            usuarioClass.contrasena = textBoxContrasena.Text;
                                            usuarioClass.IDrol = Convert.ToInt32(comboBoxRol.SelectedValue);

                                            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este usuario?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                if (usuarioClass.Modificar(id))
                                                {
                                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    CleanText();
                                                    row.Selected = false;
                                                    selectModeRow = false;
                                                    ActualizarGrid();
                                                }
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe seleccionar un usuario para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La contraseña deben ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Repita la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Debe buscar un usuario y despues seleccionarlo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            try
            {
                if (row.Selected == true)
                {
                    if (row.Cells[0].Value.ToString() != "")
                    {
                       // usuarioClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (usuarioClass.Borrar(Convert.ToInt32(row.Cells[0].Value.ToString())))
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
                        MessageBox.Show("Seleccione un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Primero busque un usuario y seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            id = Convert.ToInt32(row.Cells[0].Value.ToString());

            comboBoxRol.SelectedValue = Convert.ToInt32(row.Cells[1].Value.ToString());
            textBoxNombre.Text = row.Cells[2].Value.ToString();
            textBoxContrasena.Text = row.Cells[3].Value.ToString();
            textBoxRcontrasena.Text = row.Cells[3].Value.ToString();
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
                        if (comboBoxBuscar.Text == "ID de usuario")
                        {

                            Usuarios_Bus.IDusuario = Convert.ToInt32(tbuscarpor.Text);

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = usuarioClass.BuscarxID(Convert.ToInt32(tbuscarpor.Text));

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este usuario no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (comboBoxBuscar.Text == "Nombre de usuario")
                        {
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = usuarioClass.BuscarxNombre(tbuscarpor.Text);

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick(sender, null); 
        }

    }
}
