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
    public partial class ProductosConcept : Form
    {
        public ProductosConcept()
        {
            InitializeComponent();
        }

        Productos_Bus productoLogic = new Productos_Bus();
        Validaciones validar = new Validaciones();
        public static int tiporol { get; set; }
        bool selectModeRow = false;
        string siono = "NO";

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == false)
                {
                    if (textBoxProducto.Text != "")
                    {
                        if (textBoxPrecio.Text != "" && validar.ValidateNumeric(textBoxPrecio.Text))
                            {
                               if (checkBoxSI.Checked != false || checkBoxNO.Checked != false)
                                {
                                    if (textBoxCantidad.Text != "")
                                    {
                                        Productos_Bus.Producto = textBoxProducto.Text;
                                        Productos_Bus.Precio = Convert.ToDecimal(textBoxPrecio.Text);
                                        Productos_Bus.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                       
                                       
                                        if (checkBoxSI.Checked == true)
                                        {
                                            siono= "SI";
                                        }
                                        else if (checkBoxNO.Checked == true)
                                        {
                                            siono = "NO";
                                        }

                                        Productos_Bus.Estatus = siono;
                                        
                                        //product.idproducto = 
                                        // product.producto = textBoxNombre.Text;
                                        //product.precio = Convert.ToDecimal(textBoxPrecio.Text);

                                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar este producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            if (productoLogic.Guardar())
                                            {
                                                CleanText();
                                                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Elija una opcion para rebajar del Inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                }
                            else
                            {
                                MessageBox.Show("Llene el campo Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                       
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un producto seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void CleanText()
        {
            textBoxProducto.Clear();
            textBoxPrecio.Clear();
            textBoxCantidad.Value = 1;
            checkBoxSI.Checked = false;
            checkBoxNO.Checked = false;
            dataGridView1.DataSource = productoLogic.BuscarUltimosProductos();
        }

        public void ActualizarGrid()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = productoLogic.BuscarUltimosProductos();
        }

        private void ProductosConcept_Load(object sender, EventArgs e)
        {
            Permisos();
            ActualizarGrid();
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

        private void checkBoxNO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNO.Checked == true)
            {
                textBoxCantidad.Enabled = false;
                textBoxCantidad.Value = 0;
            }
        }

        private void checkBoxSI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSI.Checked == true)
            {
                textBoxCantidad.Enabled = true;
            }
        }
        DataGridViewRow row;
        int idProducto;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            idProducto = Convert.ToInt32(row.Cells[0].Value.ToString());

            textBoxProducto.Text = row.Cells[1].Value.ToString();
            textBoxPrecio.Text = row.Cells[2].Value.ToString();
            textBoxCantidad.Text = row.Cells[3].Value.ToString();

            if (row.Cells[4].Value.ToString()=="SI")
            {
                checkBoxSI.Checked = true;
            }
            else
            {
                checkBoxNO.Checked = true;
            }

            selectModeRow = row.Selected;    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            bGuardar.Enabled = true;
            CleanText();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                if (comboBoxBuscar.Text != "")
                {
                    if (tbuscarpor.Text != "")
                    {
                        if (comboBoxBuscar.Text == "Nombre del Producto")
                        {
                            //dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = productoLogic.BuscarxNombre(tbuscarpor.Text);

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Producto no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
//            Nombre del Producto
//Ultimos Clientes
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text == "Ultimos Productos")
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = productoLogic.BuscarUltimosProductos();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
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
                    // clientesclass.idcliente = Convert.ToInt32(row.Cells[0].Value.ToString());
                    if (productoLogic.Borrar(idProducto))
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

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModeRow == true)
                {
                    if (textBoxProducto.Text != "")
                    {
                        if (textBoxPrecio.Text != "" && validar.ValidateDecimal(textBoxPrecio.Text))
                        {
                            if (checkBoxSI.Checked != false || checkBoxNO.Checked != false)
                            {
                                if (textBoxCantidad.Text != "")
                                {
                                    Productos_Bus.Producto = textBoxProducto.Text;
                                    Productos_Bus.Precio = Convert.ToDecimal(textBoxPrecio.Text);
                                    Productos_Bus.Cantidad = Convert.ToInt32(textBoxCantidad.Text);


                                    if (checkBoxSI.Checked == true)
                                    {
                                        siono = "SI";
                                    }
                                    else if (checkBoxNO.Checked == true)
                                    {
                                        siono = "NO";
                                    }

                                    Productos_Bus.Estatus = siono;

                                    //product.idproducto = 
                                    // product.producto = textBoxNombre.Text;
                                    //product.precio = Convert.ToDecimal(textBoxPrecio.Text);

                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar este producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (productoLogic.Modificar(idProducto))
                                        {
                                            CleanText();
                                            MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Elija una opcion para rebajar del Inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
