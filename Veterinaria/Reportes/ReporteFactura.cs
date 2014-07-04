using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Logica;
using System.Configuration;


namespace Veterinaria.Reportes
{
    public partial class ReporteFactura : Form
    {
        public ReporteFactura()
        {
            InitializeComponent();
        }

        Ventas_Bus TransationsVentas = new Ventas_Bus();

        public static int idfactura { get; set; }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                //ReportAttributes rpAtt = new ReportAttributes();

                CrystalReportFactura1.Database.Tables["vwVentasDetalles"].ApplyLogOnInfo(ConnectionInfo);
                //crystalReportViewer1.LogOnInfo.Add(ConnectionInfo);

                ParameterField PID = new ParameterField();
                PID.ParameterFieldName = "@IDFactura";
                ParameterDiscreteValue myDiscreteValue = new ParameterDiscreteValue();

                //ID de la Venta
                myDiscreteValue.Value = TransationsVentas.idventa;

                PID.CurrentValues.Add(myDiscreteValue);
                crystalReportViewer1.ParameterFieldInfo.Clear();
                crystalReportViewer1.ParameterFieldInfo.Add(PID);
                crystalReportViewer1.Refresh();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrio un error al conectarse a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
    }
}
