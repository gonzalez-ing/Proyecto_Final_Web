using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI;

namespace BLL
{
    public class RepositorioUser : RepositorioBase<Usuarios>
    {
        public static int id_Usuario = 0;

        public RepositorioUser()
        {

        }
        public static void Autenticar(string email, string clave, Page page)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            //System.Linq.Expressions.Expression<Func<Usuarios, bool>> filtrar = x => true;
            Usuarios usuario = new Usuarios();
            List<Usuarios> listUsuarios = new List<Usuarios>();

            listUsuarios = repositorio.GetList(x => x.Email == email && x.Clave == clave);
            usuario = (listUsuarios != null && listUsuarios.Count > 0) ? listUsuarios[0] : null;

            //filtrar = t => t.Email.Equals(email) && t.Clave.Equals(clave);



            if (usuario != null)
            {
                id_Usuario = usuario.UsuarioId;
                FormsAuthentication.RedirectFromLoginPage(usuario.NombreUsuario, true);
            }

            else { }

            //ScriptManager.RegisterStartupScript(page, typeof(Page), "toastr_message", script: "toastr['error'] ('Usuario o Contraseña Incorrecto');", addScriptTags: true);

        }
    }
}