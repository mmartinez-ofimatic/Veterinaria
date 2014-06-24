using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosConcept productos = new ProductosConcept();
            productos.ShowDialog();
        }

        private void animalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Animales animales = new Animales();
            animales.ShowDialog();
        }

        private void vermifugosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vermifugos vermifugos = new Vermifugos();
            vermifugos.ShowDialog();
        }
    }
}
