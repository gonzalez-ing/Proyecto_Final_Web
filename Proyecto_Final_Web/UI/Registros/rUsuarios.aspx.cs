using BLL;
using FinanzasLite2._0.Utilitarios;
using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Web.Registros
{
    public partial class rUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            NombreUsuarioTextBox1.Text = " ";
            NombreTextBox.Text = " ";
            CorreoTextBox1.Text = " ";
            ContrasenaTextBox.Text = " ";
            ConfirmarTextBox1.Text = " ";
            tipoUsuarioDropDownList.Text = " ";
            TelefonoTextBox1.Text = " ";
            CelularTextBox1.Text = " ";

        }
        public Usuarios LlenarClase(Usuarios usuarios)
        {
            usuarios.Nombre = NombreUsuarioTextBox1.Text;
            usuarios.NombreUsuario = NombreUsuarioTextBox1.Text;
            usuarios.Email = CorreoTextBox1.Text;
            usuarios.Clave = ContrasenaTextBox.Text;
            usuarios.ComprobarClave = ConfirmarTextBox1.Text;
            usuarios.TipoUsuario = tipoUsuarioDropDownList.Text;
            usuarios.Telefono = TelefonoTextBox1.Text;
            usuarios.Celular = CelularTextBox1.Text;
            usuarios.Fecha = DateTime.Now.Date;

            return usuarios;
        }


        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = repositorio.Buscar(Utils.ToInt(UsuarioIdTextBox.Text));

            if (usuarios != null)
            {
                Utils.ShowToastr(this, "Encontrado", "Success", "info");
                NombreTextBox.Text = usuarios.Nombre;
                NombreUsuarioTextBox1.Text = usuarios.NombreUsuario;
                CorreoTextBox1.Text = usuarios.Email;
                ContrasenaTextBox.Text = usuarios.Clave;
                ConfirmarTextBox1.Text = usuarios.ComprobarClave;
                TelefonoTextBox1.Text = usuarios.Telefono;
                CelularTextBox1.Text = usuarios.Celular;
                tipoUsuarioDropDownList.Text = usuarios.TipoUsuario;
            }
            else
            {
                Utils.ShowToastr(this, "No Se Encontro  Resultado", "Error", "error");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            bool paso = false;


            LlenarClase(usuarios);

            if (IsValid)
            {
                if (usuarios.UsuarioId == 0)
                {
                    if (paso = repositorio.Guardar(usuarios))

                        Utils.ShowToastr(this, "GUARDADO", "Success", "success");

                    else
                    {
                        Utils.ShowToastr(this, "ERROR AL GUARDAR ", "Error", "error");
                    }
                    Limpiar();
                }

                else
                {
                    if (paso = repositorio.Modificar(usuarios))
                    {
                        Utils.ShowToastr(this, "Modificado ", "Info", "info");
                        Limpiar();
                    }
                    else
                    {
                        Utils.ShowToastr(this, "ERROR AL MODIFICAR ", "Error", "error");
                    }
                }
            }

        }

        protected void eliminarutton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Usuarios> repositorio = new BLL.RepositorioBase<Usuarios>();
            int id = Utils.ToInt(UsuarioIdTextBox.Text);

            var usuario = repositorio.Buscar(id);

            if (usuario == null)
                Utils.ShowToastr(this, " Error Al ELIMINADO", "Error", "error");

            else
                repositorio.Eliminar(id);
            Utils.ShowToastr(this, " ELIMINADO ", "Info", "info");


        }

        protected void ConfirmarCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (ConfirmarTextBox1.Text != ContrasenaTextBox.Text)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}