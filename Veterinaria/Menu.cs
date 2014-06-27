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

        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vacunas vacuna = new Vacunas();
            vacuna.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rolesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.ShowDialog();
        }

    }
}
