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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        Dictionary<int, string> almacenKeyValue;
        bool selectModeRow = false;
        int idAnimal;
        DataGridViewRow row;
        Productos_Bus almacen = new Productos_Bus();

        public static int tiporol { get; set; }

      
        private void bBuscarDueño_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductos productos = new Consultas.BuscarProductos();
            productos.ShowDialog(this);
            if (productos.id != 0 && productos.producto != null)
            {
                almacenKeyValue = new Dictionary<int, string>();
                almacenKeyValue.Add(productos.id, productos.producto);
                textBoxProducto.Text = almacenKeyValue[productos.id];
                textBoxPrecio.Text = productos.precio;

            }
        }


        public void CleanText()
        {
          
            textBoxProducto.Clear();
            textBoxPrecio.Clear();
            textBoxCantidad.Value = 0;
           
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxProducto.Text != "")
                {
                    if (textBoxCantidad.Value != 0)
                    {
                        //almacen.IDproducto = comboBoxID.Text;
                        //almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);

                       // almacen.IDproducto = textBoxIDProducto.Text;
                       // Productos_Bus.Cantidad = Convert.ToInt32(textBoxCantidad.Text);



                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea agregar " + textBoxCantidad.Text + " existencia mas a este producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //key del dictionario
                            if (almacen.AgregarExistenciadeProducto(almacenKeyValue.Keys.First(), Convert.ToInt32(textBoxCantidad.Text)))
                            {
                                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanText();
                                //comboBoxID.SelectedIndex = 0;
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Llene el campo Existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Elija un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanText();
            }


        }
    }
}
