using Microsoft.Reporting.WebForms;
using Proyecto_Final_Web.UI.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Web.Reportes
{
    public partial class UsuarioReporteView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListadoUsuarios.ProcessingMode = ProcessingMode.Local;
                ListadoUsuarios.Reset();
                ListadoUsuarios.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\UsuarioReporte.rdlc");
                ListadoUsuarios.LocalReport.DataSources.Clear();
                ListadoUsuarios.LocalReport.DataSources.Add(new ReportDataSource("Usuarios", cUsuarios1.lista));
                ListadoUsuarios.LocalReport.Refresh();
            }
        }
    }
}