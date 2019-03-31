using BLL;
using FinanzasLite2._0.Utilitarios;
using Microsoft.Reporting.WebForms;
using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Web.UI.Consultas
{
    public partial class cVentas : System.Web.UI.Page
    {

        Expression<Func<Facturas, bool>> filtro = c => true;
        public static List<Facturas> lista = new List<Facturas>();
        RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();

        protected void Page_Load(object sender, EventArgs e)
        {
            DesdeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            HastaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lista = repositorio.GetList(filtro);
            if (!Page.IsPostBack)
            {
                VentasReporteView.ProcessingMode = ProcessingMode.Local;
                VentasReporteView.Reset();
                VentasReporteView.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\ListadoVentas.rdlc");
                VentasReporteView.LocalReport.DataSources.Clear();
                VentasReporteView.LocalReport.DataSources.Add(new ReportDataSource("Ventas", lista));
                VentasReporteView.LocalReport.Refresh();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
            DateTime hasta = Convert.ToDateTime(HastaTextBox.Text);
            switch (BuscarPorDropDownList.SelectedIndex)
            {
                case 0://Todo
                    filtro = c => true;
                    break;

                case 1://FacturaId
                    id = Utils.ToInt(FiltroTextBox.Text);
                    filtro = c => c.FacturaId == id;
                    break;

                case 2://Fecha
                    filtro = p => true && p.Fecha >= desde && p.Fecha <= hasta;
                    break;
                case 3:
                    id = Utils.ToInt(FiltroTextBox.Text);
                    filtro = c => c.ClienteId == id;
                    break;

            }
            lista = repositorio.GetList(filtro);
            DatosGridView.DataSource = lista;
            DatosGridView.DataBind();
        }
    }
}