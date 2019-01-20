using BLL;
using FinanzasLite2._0.Utilitarios;
using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Web.Form
{
    public partial class rUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void LimpiarTextBox()
        {
            UsuarioIdTextBox.Text = "";
          NombreTextBox.Text = "";
            UsuarioTextBox.Text = "";
            ClaveTextBox.Text = "";
        }
        public Usuarios LlenarClase(Usuarios usuarios)
        {
            // BLL.RepositorioBase<Usuarios> usuario = new BLL.RepositorioBase<Usuarios>();

            usuarios.Usuario = UsuarioTextBox.Text;
            usuarios.Nombre = NombreTextBox.Text;
           usuarios.Clave = ClaveTextBox.Text;
            return usuarios;
        }


        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            bool paso = false;

            //todo: validaciones adicionales
            LlenarClase(usuarios);

            if (usuarios.UsuarioId == 0)
                paso = repositorio.Guardar(usuarios);
            else
                paso = repositorio.Modificar(usuarios);

            if (paso)
            {
                // MostrarMensaje(TiposMensaje.Success, "Transaccion Exitosa!");
                //Limpiar();
            }
            else
            {

            }
            // MostrarMensaje(TiposMensaje.Error, "No fue posible terminar la transacción");
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = repositorio.Buscar(int.Parse(UsuarioIdTextBox.Text));
            if (usuarios != null)
            {
                NombreTextBox.Text = usuarios.Nombre;
                UsuarioTextBox.Text = usuarios.Usuario;
                ClaveTextBox.Text = usuarios.Clave;

            }
            else
            {
                Response.Write("<script>alert('Usuario  no existe');</script>");
               
            }

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();
            int id = Utils.ToInt(UsuarioIdTextBox.Text);

            var categoria = repositorio.Buscar(id);

            if (categoria == null)
                Response.Write("<script>alert('Error al Eliminar');</script>");
            else
                repositorio.Eliminar(id);
            Response.Write("<script>alert(' Usuario Eliminada');</script>");
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
    


   
