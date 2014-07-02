using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Veterinaria.Consultas
{
    public partial class BuscarVentasDetalles : Form
    {
        public BuscarVentasDetalles()
        {
            InitializeComponent();
        }

        Ventas_Bus ventasClass = new Ventas_Bus();

        public static int idVentaDetalles { get; set; }
        public static string cliente { get; set; }
        public static string totalNeto { get; set; }
        public static string vendedor { get; set; }
        public static string fecha { get; set; }
        public static string observacion { get; set; }

        private void BuscarVentasDetalles_Load(object sender, EventArgs e)
        {
            DataTable table = GetTable();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            dataGridView2.DataSource = table;
           
            dataGridView1.DataSource = ventasClass.BuscarDetallesVentas(idVentaDetalles);        
        }

        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("ID_Venta", typeof(int));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Total", typeof(string));
            table.Columns.Add("Vendedor", typeof(string));
            table.Columns.Add("Fecha", typeof(string));
            table.Columns.Add("Observacion", typeof(string));

            table.Rows.Add(idVentaDetalles, cliente, totalNeto, vendedor, fecha, observacion);

            return table;
        }
    }
}
