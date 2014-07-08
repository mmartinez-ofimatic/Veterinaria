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
    public partial class Vermifugos : Form
    {
        public Vermifugos()
        {
            InitializeComponent();
        }

        Vermifugos_Bus vermifugos = new Vermifugos_Bus();
        Animales_Bus animales = new Animales_Bus();
        public static int tiporol { get; set; }
        Dictionary<int, string> vermifugoKeyValue;
        bool selectModeRow = false;
        DataGridViewRow row;
        int idVermifugo;

        private void bBuscarDueño_Click(object sender, EventArgs e)
        {
            Consultas.BuscarAnimales buscar = new Consultas.BuscarAnimales();
            buscar.ShowDialog();

            if (buscar.idAnimal != null && buscar.nombre != null)
            {
                vermifugoKeyValue = new Dictionary<int, string>();
                vermifugoKeyValue.Add(buscar.idAnimal, buscar.nombre);
                textBoxAnimal.Text = vermifugoKeyValue[buscar.idAnimal];
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
                {
                    if (textBoxAnimal.Text != "")
                    {
                        if (textBoxVermifugo.Text != "")
                        {
                            if (textBoxResultados.Text != "")
                            {
                                
                                    Vermifugos_Bus.ID_Animal = vermifugoKeyValue.Keys.First();
                                    Vermifugos_Bus.Vermifugo = textBoxVermifugo.Text;
                                    Vermifugos_Bus.Resultados = textBoxResultados.Text;
                                  
                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (vermifugos.Guardar())
                                        {
                                            CleanText();
                                            actualizarDatagrid();
                                            MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                              
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Nombre del Vermifugo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un vermifugo seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void CleanText()
        {
            textBoxAnimal.Clear();
            textBoxVermifugo.Clear();
            textBoxResultados.Clear();
            
            selectModeRow = false;
            actualizarDatagrid();
        }

        public void actualizarDatagrid()
        {
            dataGridViewAnimal.AutoGenerateColumns = false;
            dataGridViewAnimal.DataSource = vermifugos.BuscarUltimosVermifugos();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == true)
                {
                   if (textBoxAnimal.Text != "")
                    {
                        if (textBoxVermifugo.Text != "")
                        {
                            if (textBoxResultados.Text != "")
                            {
                                    Vermifugos_Bus.ID_Animal = vermifugoKeyValue.Keys.First();
                                    Vermifugos_Bus.Vermifugo = textBoxVermifugo.Text;
                                    Vermifugos_Bus.Resultados = textBoxResultados.Text;
                                 
                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este vermifugo?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (vermifugos.Modificar(idVermifugo))
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
                                MessageBox.Show("Llene el campo Resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Nombre del Vermifugo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            idVermifugo = Convert.ToInt32(row.Cells[0].Value.ToString());
          
            // Dictionary<string, string> clientesKeyValue = new Dictionary<string, string>();

            vermifugoKeyValue = new Dictionary<int, string>();
            vermifugoKeyValue = animales.BuscarxAnimalKey(Convert.ToInt32(row.Cells[1].Value.ToString()));

            textBoxAnimal.Text = vermifugoKeyValue.Values.First();

            textBoxVermifugo.Text = row.Cells[3].Value.ToString();
            textBoxResultados.Text = row.Cells[4].Value.ToString();
           
            bGuardar.Enabled = false;
            idVermifugo = Convert.ToInt32(row.Cells[0].Value.ToString());
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
                      DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar este vermifugo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                      if (dialogResult == DialogResult.Yes)
                      {
                          if (vermifugos.Borrar(idVermifugo))
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
                    MessageBox.Show("Primero busque un vermifugo y luego seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, trate de eliminar nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Vermifugos_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ultimos Vermifugos")
            {
                dataGridViewAnimal.AutoGenerateColumns = false;
                dataGridViewAnimal.DataSource = vermifugos.BuscarUltimosVermifugos();

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

                        dataGridViewAnimal.DataSource = vermifugos.BuscarxNombreAnimal(tbuscarpor.Text);
                        if (dataGridViewAnimal.RowCount == 0)
                        {
                            MessageBox.Show("Esta Mascota no existe o no tiene vermifugos!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBox1.Text == "Nombre del Vermifugo")
                    {
                        dataGridViewAnimal.AutoGenerateColumns = false;

                        dataGridViewAnimal.DataSource = vermifugos.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridViewAnimal.RowCount == 0)
                        {
                            MessageBox.Show("Este Vermifugo no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridViewAnimal_DoubleClick(object sender, EventArgs e)
        {
            dataGridViewAnimal_CellContentClick(sender, null);
        }


    }
}
