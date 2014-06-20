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
    public partial class Animales : Form
    {
        public Animales()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void bBuscarDueño_Click(object sender, EventArgs e)
        {
            Consultas.BuscarDueno buscar = new Consultas.BuscarDueno();
            buscar.ShowDialog();
        }
    }
}
