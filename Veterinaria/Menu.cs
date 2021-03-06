﻿using System;
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

        public static int tiporol { get; set; }
        public static string nameUser { get; set; }

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
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {


                dialogResult = MessageBox.Show("¿Estas seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            //DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void rolesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.ShowDialog();
        }

        private void usuariosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.ShowDialog();
        }

        private void consultarAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarAnimales animales = new Consultas.BuscarAnimales();
            animales.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarDueno cliente = new Consultas.BuscarDueno();
            cliente.ShowDialog();
        }

        private void consultarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductos productos = new Consultas.BuscarProductos();
            productos.ShowDialog();
        }

        private void consultarVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarVacunas vacuna = new Consultas.BuscarVacunas();
            vacuna.ShowDialog();
        }

        private void yConsultarVermifugosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarVermifugos vermifugos = new Consultas.BuscarVermifugos();
            vermifugos.ShowDialog();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarVentas ventas = new Consultas.BuscarVentas();
            ventas.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_FormClosed(sender, null);
            //Application.Exit();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteClientes clientes = new Reportes.ReporteClientes();
            clientes.ShowDialog();
        }

        private void reporteDeMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteAnimalescs mascotas = new Reportes.ReporteAnimalescs();
            mascotas.ShowDialog();
        }

        private void reporteDeVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVacunascs vacuna = new Reportes.ReporteVacunascs();
            vacuna.ShowDialog();
        }

        private void reporteDeVermifugosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVermifugoscs vermifugos = new Reportes.ReporteVermifugoscs();
            vermifugos.ShowDialog();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteProductos productos = new Reportes.ReporteProductos();
            productos.ShowDialog();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVentas ventas = new Reportes.ReporteVentas();
            ventas.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteFactura fact = new Reportes.ReporteFactura();
            fact.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Permisos();
        }

        public void Permisos()
        {
            if (tiporol == 1)
            {
                usuariosToolStripMenuItem.Visible = true;
               toolStripUsuario.Text = nameUser;
            }
            else if (tiporol == 2)
            {
                usuariosToolStripMenuItem.Visible = false;
                toolStripUsuario.Text = nameUser;
            }
            else if (tiporol == 3)
            {
                
                usuariosToolStripMenuItem.Visible = false;
                toolStripUsuario.Text = nameUser;
            }
            else if (tiporol == 4)
            {
                ventasToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Visible = false;
                toolStripUsuario.Text = nameUser;
            }
            else
            {
                ventasToolStripMenuItem.Enabled = false;
                usuariosDelSistemaToolStripMenuItem.Visible = false;
                MessageBox.Show("Usted no tiene permiso para acceder al sistema!", "Usuario sin permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripUsuario_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeMascotasConVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteAnimalesVacunas av = new Reportes.ReporteAnimalesVacunas();
            av.ShowDialog();
        }
        DialogResult dialogResult;
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
        
            
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog();
        }

       

    }
}
