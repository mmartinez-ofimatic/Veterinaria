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
        bool selectModeRow = false;
        int idusuario;

        //Consultas.BuscarProductosVentas buscarProducto = new Consultas.BuscarProductosVentas();
        AgregarVentas productVentasList = new AgregarVentas();
        //List<AgregarVentas> lista = new List<AgregarVentas>();
        //AgregarVentas v = new AgregarVentas();
        Dictionary<string, string> clienteKeyValue;
        Dictionary<int, string> productoKeyValue;


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
                bRealizarVenta.Enabled = false;
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
            textBoxCliente.Text = productoKeyValue[buscar.id];
        }

    }
}
