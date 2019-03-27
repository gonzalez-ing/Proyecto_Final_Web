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
    public partial class rProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        {
            ProductoIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CostoTextBox.Text = "";
            NombreTextBox.Text = " ";
            PrecioTextBox.Text = "";
            GananciaTextBox.Text = "";
            InventarioTextBox.Text = "";
        }

        private Productos LlenarClase(Productos producto)
        {


            producto.ProductoId = Utils.ToInt(ProductoIdTextBox.Text);
            producto.Nombre = NombreTextBox.Text;
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Costo = Utils.ToInt(CostoTextBox.Text);
            producto.Precio = Utils.ToInt(PrecioTextBox.Text);
            producto.Ganancia = Utils.ToInt(GananciaTextBox.Text);
            producto.Inventario = Utils.ToInt(InventarioTextBox.Text);

            return producto;
        }

        private void LlenaCampos(Productos productos)
        {
            ProductoIdTextBox.Text = productos.ProductoId.ToString();
            NombreTextBox.Text = productos.Nombre.ToString();
            CostoTextBox.Text = productos.Costo.ToString();
            PrecioTextBox.Text = productos.Precio.ToString();
            GananciaTextBox.Text = productos.Ganancia.ToString();
            InventarioTextBox.Text = productos.Inventario.ToString();
        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            BLL.RepositorioBase<Productos> repositorio = new BLL.RepositorioBase<Productos>();
            Productos productos = new Productos();
            bool paso = false;

            //todo: validaciones adicionales
            LlenarClase(productos);

            if (IsValid)
            {
                if (productos.ProductoId == 0)
                {
                    if (paso = repositorio.Guardar(productos))

                        Utils.ShowToastr(this, "GUARDADO", "Success", "success");

                    else
                    {
                        Utils.ShowToastr(this, "ERROR AL GUARDAR ", "Error", "error");

                    }
                    Limpiar();
                }

                else
                {
                    if (paso = repositorio.Modificar(productos))
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

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = repositorio.Buscar(Utils.ToInt(ProductoIdTextBox.Text));
            if (IsValid)
            {
                if (producto != null)
                {
                    Utils.ShowToastr(this, " Encontrado ", "Success", "info");
                    Limpiar();
                    LlenaCampos(producto);
                }
                else
                {
                    Utils.ShowToastr(this, "No Se Encontro  Resultado", "Error", "error");
                    Limpiar();
                }
            }
        }

        protected void eliminarutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = repositorio.Buscar(Utils.ToInt(ProductoIdTextBox.Text));
            if (IsValid)
            {
                if (producto != null)
                {
                    repositorio.Eliminar(producto.ProductoId);
                    Utils.ShowToastr(this, " ELIMINADO ", "Info", "info");
                    Limpiar();
                }
                else
                {
                    Utils.ShowToastr(this, " ELIMINADO ", "Erroe", "error");
                    Limpiar();
                }
            }
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}