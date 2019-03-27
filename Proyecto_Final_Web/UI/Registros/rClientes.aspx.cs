using BLL;
using FinanzasLite2._0.Utilitarios;
using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Web.UI.Registros
{
    public partial class rClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
              //  LlenarClase();
                FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                int id = Utils.ToInt(Request.QueryString["id"]);
                if (id > 0)
                {
                    RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
                    var cliente = repositorio.Buscar(id);

                    if (cliente == null)
                        Utils.ShowToastr(this, "Error  ", "Error", "error");
                    else
                        LlenarClase(cliente);
                }
            }
        }
        private Clientes LlenarClase(Clientes cliente)
        {

            cliente.ClienteId = Utils.ToInt(ClienteIdTextBox.Text);
            cliente.Fecha = Convert.ToDateTime(FechaTextBox.Text).Date;
            cliente.Nombre = NombreTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Cedula = CedulaTextBox.Text;
            cliente.Telefono = TelefonoTextBox.Text;

            return cliente;
        }

        private void Limpiar()
        {
            ClienteIdTextBox.Text = "";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            NombreTextBox.Text = "";
            DireccionTextBox.Text = "";
            CedulaTextBox.Text = "";
            TelefonoTextBox.Text = "";

        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Clientes> repositorio = new BLL.RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            bool paso = false;

            LlenarClase(clientes);

            if (IsValid)
            {
                if (clientes.ClienteId == 0)
                {
                    if (paso = repositorio.Guardar(clientes))

                        Utils.ShowToastr(this, "saved successfully", "Success", "success");

                    else
                    {
                        Utils.ShowToastr(this, "No se pudo Guardar", "Error", "error");

                    }
                    Limpiar();
                }

                else
                {
                    if (paso = repositorio.Modificar(clientes))
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

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void eliminarutton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Clientes> repositorio = new BLL.RepositorioBase<Clientes>();
            int id = Utils.ToInt(ClienteIdTextBox.Text);

            var clientes = repositorio.Buscar(id);

            if (clientes == null)
                Utils.ShowToastr(this, "no found", "Error", "error");

            else
                repositorio.Eliminar(id);
            Utils.ShowToastr(this, " ELIMINADO ", "Info", "info");
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = repositorio.Buscar(Utils.ToInt(ClienteIdTextBox.Text));

            if (IsValid)
            {
                if (clientes != null)
                {

                    Utils.ShowToastr(this, " Encontrado ", "Success", "info");
                    Limpiar();
                    LlenarClase(clientes);
                }
                else
                {
                    Utils.ShowToastr(this, "No Hay Resultado", "Error", "error");
                    Limpiar();
                }
            }
        }
    }
}