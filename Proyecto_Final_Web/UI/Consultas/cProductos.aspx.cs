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
    public partial class cProductos : System.Web.UI.Page
    {
        Expression<Func<Productos, bool>> filtro = c => true;
        public static List<Productos> lista = new List<Productos>();
        RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

        protected void Page_Load(object sender, EventArgs e)
        {
            lista = repositorio.GetList(filtro);
            if (!Page.IsPostBack)
            {
                ProductosReporteView.ProcessingMode = ProcessingMode.Local;
                ProductosReporteView.Reset();
                ProductosReporteView.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\ListadoProductos.rdlc");
                ProductosReporteView.LocalReport.DataSources.Clear();
                ProductosReporteView.LocalReport.DataSources.Add(new ReportDataSource("Productos", lista));
                ProductosReporteView.LocalReport.Refresh();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            switch (BuscarPorDropDownList.SelectedIndex)
            {
                case 0://Todo
                    filtro = c => true;
                    break;

                case 1://ClienteId
                    id = Utils.ToInt(FiltroTextBox.Text);
                    filtro = c => c.ProductoId == id;
                    break;
                case 2:
                    filtro = c => c.Nombre.Contains(FiltroTextBox.Text);
                    break;
            }

            lista = repositorio.GetList(filtro);
            DatosGridView.DataSource = lista;
            DatosGridView.DataBind();
        }
    }
}