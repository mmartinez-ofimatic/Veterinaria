using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Logica;
using System.Configuration;

namespace Veterinaria.Reportes
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
           
        }

        public TableLogOnInfo ConnectionInfo
        {
            get
            {   //ojo Hay que asignarle el appconfig de IVR-CLI para que coja el Array de los Datos de la Conection (Credenciales).
                TableLogOnInfo info = new TableLogOnInfo();
                string[] valor = ConfigurationManager.ConnectionStrings["veterinariaDBEntities"].ConnectionString.Split(';');

                info.ConnectionInfo.UserID = (valor[4].Split('=').GetValue(1).ToString()).Trim();
                info.ConnectionInfo.Password = (valor[5].Split('=').GetValue(1).ToString()).Trim();
                info.ConnectionInfo.DatabaseName = (valor[3].Split('=').GetValue(1).ToString()).Trim();
                info.ConnectionInfo.ServerName = (valor[2].Split('"').GetValue(1).ToString()).Split('=').GetValue(1).ToString();

                return info;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
