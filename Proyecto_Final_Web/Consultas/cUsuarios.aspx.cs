using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Web.Consultas
{
    public partial class cUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtro = x => true;
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();

            int id;

            switch (BuscarPorDropDownList.SelectedIndex)
            {
                case 0://ID
                     

                    int.TryParse(FiltroTextBox.Text, out id);
                    filtro = c => c.UsuarioId == id;
                   
                    break;
                case 1:// nombre
                    filtro = c => c.Nombre.Contains(FiltroTextBox.Text);
                    break;
            }

            DatosGridView.DataSource = repositorio.GetList(filtro);
            DatosGridView.DataBind();
        }
    }
}