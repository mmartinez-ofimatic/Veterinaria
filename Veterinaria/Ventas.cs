using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace Veterinaria
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        public static int tiporol { get; set; }
        Venta_Factura ventasClass = new Venta_Factura();
        DataGridViewRow rowCurrent;  
        AgregarVentas productVentasList = new AgregarVentas();
        Dictionary<string, string> clienteKeyValue;
        Dictionary<int, string> productoKeyValue;
        List<AgregarVentas> listaNueva;
        DataGridViewRow rowProducto;
        Dictionary<string, string> updateDictionary = new Dictionary<string, string>();
        TransationsVentas transationsVentas = new TransationsVentas();
        string idupdate;
        int index;
        bool selectModeRow = false;
        int idusuario;

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            Consultas.BuscarDueno buscar = new Consultas.BuscarDueno();
            buscar.ShowDialog(this);

            clienteKeyValue = new Dictionary<string, string>();
            clienteKeyValue.Add(buscar.cedula, buscar.cliente);
            textBoxCliente.Text = clienteKeyValue[buscar.cedula];
        }

        private void bNuevaVenta_Click(object sender, EventArgs e)
        {
            if (dataGridViewVentas.RowCount != 0)
            {
                DialogResult dialogResult = MessageBox.Show("La venta en proceso se va a borrar ¿Esta seguro?", "Nueva venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //textBoxPrecio.ReadOnly = false;
                    textBoxCantidad.ReadOnly = false;
                    textBoxDescuento.ReadOnly = false;
                    textBoxObservacion1.ReadOnly = false;
                    bBuscarCliente.Enabled = true;
                    bBuscarProductos.Enabled = true;
                    bAgregar.Enabled = true;
                    bRealizarVenta.Enabled = false;
                    dataGridViewVentas.DataSource = null;
                    
                    productVentasList.EraserList();
                    CleanProductos();
                    CleanText();
                }
            }
            else
            {
                //textBoxPrecio.ReadOnly = false;
                textBoxCantidad.ReadOnly = false;
                textBoxDescuento.ReadOnly = false;
                textBoxObservacion1.ReadOnly = false;
                bBuscarCliente.Enabled = true;
                bBuscarProductos.Enabled = true;
                bAgregar.Enabled = true;
                bModificar.Enabled = true;
                bBorrar.Enabled = true;
                bRealizarVenta.Enabled = true;
                dataGridViewVentas.DataSource = null;
               
                productVentasList.EraserList();
                CleanProductos();
                CleanText();
            }
            productoKeyValue = new Dictionary<int, string>();
        }

        public void CleanText()
        {
            selectModeRow = false;
            textBoxCliente.Clear();
            textBoxProducto.Clear();
            textBoxPrecio.Clear();
            textBoxCantidad.Value = 1;
            textBoxDescuento.Value = 0;
            textBoxObservacion1.Clear();
        }

        public void CleanProductos()
        {
            //textBoxCliente.Clear();
            textBoxProducto.Clear();
            textBoxPrecio.Clear();
            textBoxCantidad.Value = 1;
            textBoxDescuento.Value = 0;
            //textBoxObservacion.Clear();
        }

        private void bBuscarProductos_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductos buscar = new Consultas.BuscarProductos();
            buscar.ShowDialog(this);

            productoKeyValue = new Dictionary<int, string>();
            productoKeyValue.Add(buscar.id, buscar.producto);
            textBoxProducto.Text = productoKeyValue[buscar.id];
            textBoxPrecio.Text = buscar.precio;

            if (buscar.estatus == "NO")
            {
                textBoxCantidad.Value = 1;
                textBoxCantidad.Enabled = false;
            }

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxProducto.Text != "")
            {
                if (textBoxPrecio.Text != "")
                {
                    if (textBoxCantidad.Value.ToString() != "")
                    {
                        if (textBoxDescuento.Value.ToString() != "")
                        {
                            /*.Select(x=>x.Key).Single()*/
                            if (!productVentasList.ExistProductList(productoKeyValue.Select(x => x.Key).Single()))
                            {
                                bRealizarVenta.Enabled = true;
                                dataGridViewVentas.DataSource = null;

                                listaNueva = productVentasList.addList(productoKeyValue, decimal.Parse(textBoxPrecio.Text),
                                                 int.Parse(textBoxCantidad.Value.ToString()), double.Parse(textBoxDescuento.Value.ToString()));

                                var filtro = (from c in listaNueva
                                              select new
                                              {
                                                  idProducto = c.Producto.Select(x => x.Key).Single(),
                                                  Producto = c.Producto.Select(x => x.Value).Single(),
                                                  c.Precio,
                                                  c.Cantidad,
                                                  c.Descuento,
                                                  c.PrecioNeto
                                              }).ToList();

                                dataGridViewVentas.DataSource = filtro;

                                CleanProductos();
                            }
                            else
                            {
                                MessageBox.Show("Este producto ya esta agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Elija un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowProducto = dataGridViewVentas.CurrentRow;
            rowProducto.Selected = false;
            bAgregar.Enabled = true;
            bBorrar.Enabled = false;
            bModificar.Enabled = false;
            bBuscarProductos.Enabled = true;
            bRealizarVenta.Enabled = true;
            CleanProductos();
        }

        private void dataGridViewVentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowProducto = dataGridViewVentas.CurrentRow;
            index = rowProducto.Index;
            bAgregar.Enabled = false;
            bBuscarProductos.Enabled = false;
            bBorrar.Enabled = true;
            bModificar.Enabled = true;
            bRealizarVenta.Enabled = false;
            idupdate = rowProducto.Cells[0].Value.ToString();
            textBoxProducto.Text = rowProducto.Cells[1].Value.ToString();
            textBoxPrecio.Text = rowProducto.Cells[2].Value.ToString();
            textBoxCantidad.Text = rowProducto.Cells[3].Value.ToString();
            textBoxDescuento.Text = rowProducto.Cells[4].Value.ToString();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            if (textBoxProducto.Text != "")
            {
                if (textBoxPrecio.Text != "")
                {
                    if (textBoxCantidad.Value.ToString() != "")
                    {
                        if (textBoxDescuento.Value.ToString() != "")
                        {
                            dataGridViewVentas.DataSource = null;
                            var listaUpdate = productVentasList.UpdateList(/*int.Parse(textBoxProducto.Text)*/productoKeyValue, idupdate, decimal.Parse(textBoxPrecio.Text),
                                                              int.Parse(textBoxCantidad.Value.ToString()), double.Parse(textBoxDescuento.Value.ToString()));

                            var filtro = (from c in listaUpdate
                                          select new
                                          {
                                              idProducto = c.Producto.Select(x => x.Key).Single(),
                                              Producto = c.Producto.Select(x => x.Value).Single(),
                                              c.Precio,
                                              c.Cantidad,
                                              c.Descuento,
                                              c.PrecioNeto
                                          }).ToList();

                            dataGridViewVentas.DataSource = filtro;


                            rowProducto = dataGridViewVentas.CurrentRow;
                            rowProducto.Selected = false;
                            bModificar.Enabled = false;
                            bBorrar.Enabled = false;
                            bBuscarProductos.Enabled = true;
                            bAgregar.Enabled = true;
                            bRealizarVenta.Enabled = true;
                            CleanProductos();



                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Elija el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (rowProducto.Selected == true)
            {
                var borrarlist = productVentasList.RemoveList(index);

                var filtro = (from c in borrarlist
                              select new
                              {
                                  idProducto = c.Producto.Select(x => x.Key).Single(),
                                  Producto = c.Producto.Select(x => x.Value).Single(),
                                  c.Precio,
                                  c.Cantidad,
                                  c.Descuento,
                                  c.PrecioNeto
                              }).ToList();

                dataGridViewVentas.DataSource = null;
                dataGridViewVentas.DataSource = filtro;

                rowProducto.Selected = false;

                bModificar.Enabled = false;
                bBorrar.Enabled = false;
                bBuscarProductos.Enabled = true;
                bAgregar.Enabled = true;
                bRealizarVenta.Enabled = true;
                CleanProductos();
            }
        }

        private void bRealizarVenta_Click(object sender, EventArgs e)
        {
            if (textBoxCliente.Text != "")
            {
                if (dataGridViewVentas.RowCount != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea relizar esta venta?", "Realizar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            transationsVentas.cedula = clienteKeyValue.Keys.First();
                            transationsVentas.observacion = textBoxObservacion1.Text;

                            if (transationsVentas.transationsVentas(listaNueva))
                            {
                                 MessageBox.Show("Venta realizada!", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanText();
                                dataGridViewVentas.DataSource = null;

                                //InventarioCDGC.Reportes.ReporteVentasDetalle reporte = new Reportes.ReporteVentasDetalle();
                                //reporte.Show();

                                productVentasList.EraserList();
                                bRealizarVenta.Enabled = false;
                            }

                            else
                            {
                                MessageBox.Show("Realize la venta nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Realize la venta nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CleanText();
                            dataGridViewVentas.DataSource = null;
                            productVentasList.EraserList();
                            bRealizarVenta.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Agregue un producto a la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
