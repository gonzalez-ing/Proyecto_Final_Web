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
    public partial class cClientes : System.Web.UI.Page
    {
        Expression<Func<Clientes, bool>> filtro = c => true;
        public static List<Clientes> lista = new List<Clientes>();
        RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

        protected void Page_Load(object sender, EventArgs e)
        {

            DesdeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            HastaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lista = repositorio.GetList(filtro);
            if (!Page.IsPostBack)
            {
                ClienteReporteView.ProcessingMode = ProcessingMode.Local;
                ClienteReporteView.Reset();
                ClienteReporteView.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\ListadoClientes.rdlc");
                ClienteReporteView.LocalReport.DataSources.Clear();
                ClienteReporteView.LocalReport.DataSources.Add(new ReportDataSource("Clientes", lista));
                ClienteReporteView.LocalReport.Refresh();
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

                case 1://ClienteId
                    id = Utils.ToInt(FiltroTextBox.Text);
                    filtro = c => c.ClienteId == id;
                    break;

                case 2://Fecha
                    filtro = p => true && p.Fecha >= desde && p.Fecha <= hasta;
                    break;
                case 3:
                    filtro = c => c.Nombre.Contains(FiltroTextBox.Text);
                    break;

            }
            lista = repositorio.GetList(filtro);
            DatosGridView.DataSource = lista;
            DatosGridView.DataBind();
        }
    }
}