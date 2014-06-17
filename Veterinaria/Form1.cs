using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Clientes_Bus clienteLogic = new Clientes_Bus();

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Clientes_Entity.Cedula = textBoxCedula.Text;
                Clientes_Entity.Nombre = textBoxNombre.Text;
                Clientes_Entity.Telefono = textBoxTelefono.Text;
                Clientes_Entity.Celular = textBoxCelular.Text;
                Clientes_Entity.Direccion = textBoxDireccion.Text;
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (clienteLogic.Guardar())
                    {
                        CleanText();
                        MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public void CleanText()
        {
            textBoxNombre.Clear();
            textBoxCedula.Clear();
            textBoxCelular.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            //selectModeRow = false;
            //actualizarDatagrid();
        }
    }
}
