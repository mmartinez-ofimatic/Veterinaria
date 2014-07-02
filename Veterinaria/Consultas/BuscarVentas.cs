﻿using System;
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
    public partial class BuscarVentas : Form
    {
        public BuscarVentas()
        {
            InitializeComponent();
        }

        Ventas_Bus ventasClass = new Ventas_Bus();
        DataGridViewRow row;

        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBuscar.Text != "")
                {
                    if (tbuscarpor.Text != "")
                    {
                        if (comboBoxBuscar.Text == "ID de Venta")
                        {
                            Validaciones v = new Validaciones();
                            if (v.ValidateNumeric(tbuscarpor.Text))
                            {
                                dataGridView1.AutoGenerateColumns = false;
                                dataGridView1.DataSource = ventasClass.BuscarxIDVista(Convert.ToInt32(tbuscarpor.Text));
                                //dataGridView1.DataSource = ventasClass.BuscarxIDProducto(tbuscarpor.Text);

                                if (dataGridView1.RowCount == 0)
                                {
                                    MessageBox.Show("Esta Venta no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El ID de la Venta debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else if (comboBoxBuscar.Text == "Nombre del Cliente")
                        {
                            try
                            {
                                //ventasClass.idventa = Convert.ToInt32(tbuscarpor.Text);
                                dataGridView1.AutoGenerateColumns = false;
                                dataGridView1.DataSource = ventasClass.BuscarxNombreClienteVista(tbuscarpor.Text);

                                if (dataGridView1.RowCount == 0)
                                {
                                    MessageBox.Show("Este nombre no existe en las ventas realizadas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BuscarVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ventasClass.BuscarUltimasVentasVista();
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text == "Ultimas Ventas")
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ventasClass.BuscarUltimasVentasVista();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int index = e.RowIndex;
            row = dataGridView1.CurrentRow;
            Consultas.BuscarVentasDetalles.idVentaDetalles = Convert.ToInt32(row.Cells[0].Value.ToString());
            Consultas.BuscarVentasDetalles.cliente = row.Cells[1].Value.ToString();
            Consultas.BuscarVentasDetalles.totalNeto = row.Cells[5].Value.ToString();
            Consultas.BuscarVentasDetalles.vendedor = row.Cells[2].Value.ToString();
            Consultas.BuscarVentasDetalles.fecha = row.Cells[4].Value.ToString();
            Consultas.BuscarVentasDetalles.observacion = row.Cells[3].Value.ToString();

            Consultas.BuscarVentasDetalles buscarVentas = new Consultas.BuscarVentasDetalles();
            buscarVentas.ShowDialog(this);
        }
    
    
    }
}
