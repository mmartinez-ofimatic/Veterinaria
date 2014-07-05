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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Usuarios_Bus login = new Usuarios_Bus();
        
        public static int idusuario { get; set; }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            bool validate;

            try
            {
                validate = login.ValidateUsers(tusuario.Text, tpass.Text);

                if (validate == true)
                {
                    Rol_Bus roles = new Rol_Bus();

                    int permiso = roles.GetPermisos(login.IDrol);

                    Veterinaria.Menu.tiporol = permiso;
                    Clientes.tiporol = permiso;
                    ProductosConcept.tiporol = permiso;
                    Animales.tiporol = permiso;
                    Vacunas.tiporol = permiso;
                    Vermifugos.tiporol = permiso;
                    //Ventas.tiporol = roles.GetPermisos(login.IDrol);
                    //FrmAlmacen.tiporol = roles.GetPermisos(login.IDrol);

                    Veterinaria.Menu.nameUser = (roles.GetNombreRol(login.IDrol) + ": " + tusuario.Text).ToUpper();
                    idusuario = Usuarios_Bus.IDusuario;
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Password Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tpass.Clear();
                    tusuario.Clear();

                    tusuario.Select();
                    // Cursor.Current = 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tusuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                tpass.Select();
            }
        }

        private void tpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bEntrar_Click(sender, e);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
