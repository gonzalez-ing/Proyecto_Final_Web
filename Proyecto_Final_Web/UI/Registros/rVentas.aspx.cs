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
    public partial class rVentas : System.Web.UI.Page
    {
        public int row;
        private Facturas facturas = new Facturas();
        private RepositorioBase<Clientes> repositorioCliente = new RepositorioBase<Clientes>();
        private RepositorioBase<Productos> repositorioProducto = new RepositorioBase<Productos>();
        private DetalleVentas FacturaRepositorio = new DetalleVentas();
        string condicion = "[Seleccione]";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                LlenarDropDownListProductos();
                LlenarDropDownListClientes();
                ViewState["Detalle"] = new Facturas();
            }
        }

        private void Limpiar()
        {
            FacturaIdTextBox.Text = "";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            ClienteDropDownList.SelectedIndex = 0;
            ProductoDropDownList.SelectedIndex = 0;
            ImporteTextBox.Text = "";
            CantidadTextBox.Text = "";
            PrecioTextBox.Text = "";
            TotalTextBox.Text = "";
            ViewState["Detalle"] = new Facturas();
        }

        private void FiltraPrecio()
        {
            if (ProductoDropDownList.Text != condicion)
            {
                int id = Convert.ToInt32(ProductoDropDownList.SelectedValue);
                PrecioTextBox.Text = repositorioProducto.Buscar(id).Precio.ToString();
            }
            else
            {
                PrecioTextBox.Text = "";
            }
        }

        private void LlenarDropDownListProductos()
        {
            ProductoDropDownList.DataSource = repositorioProducto.GetList(x => true);
            ProductoDropDownList.DataValueField = "ProductoId";
            ProductoDropDownList.DataTextField = "Nombre";
            ProductoDropDownList.AppendDataBoundItems = true;
            ProductoDropDownList.DataBind();
            FiltraPrecio();

        }

        private void LlenarDropDownListClientes()
        {
            ClienteDropDownList.DataSource = repositorioCliente.GetList(x => true);
            ClienteDropDownList.DataValueField = "ClienteId";
            ClienteDropDownList.DataTextField = "Nombre";
            ClienteDropDownList.AppendDataBoundItems = true;
            ClienteDropDownList.DataBind();
        }

        private Facturas LlenarClase()
        {
            facturas = (Facturas)ViewState["Detalle"];
            facturas.ClienteId = Utils.ToInt(ClienteDropDownList.SelectedValue);
            facturas.Total = Utils.ToDecimal(TotalTextBox.Text);
            facturas.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            facturas.FacturaId = Utils.ToInt(FacturaIdTextBox.Text);

            return facturas;
        }

        private void LlenarCampos(Facturas facturas)
        {
            Facturas factura = (Facturas)ViewState["Detalle"];
            DetalleVentas DetalleVenta = new DetalleVentas();
         // ClienteDropDownList.SelectedValue = factura.ClienteId.ToString();
            DetalleGridView.DataSource = facturas.Detalle;
            DetalleGridView.DataBind();
            TotalTextBox.Text = factura.Total.ToString();
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            DetalleVentas repositorio = new DetalleVentas();
            var facturas = repositorio.Buscar(Utils.ToInt(FacturaIdTextBox.Text));
            if (facturas != null)
            {
                Limpiar();
                LlenarCampos(facturas);
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito");
            }
            else
            {
                Limpiar();
                Utils.ShowToastr(this,
               "No se pudo encontrar la busqueda",
               "Error", "error");
            }
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


      
        protected void LinkButton_Click(object sender, EventArgs e)
        {
            var ventaAnt = FacturaRepositorio.Buscar(Utils.ToInt(FacturaIdTextBox.Text));
            bool paso = false;

            int cantidad = Utils.ToInt(CantidadTextBox.Text);
            decimal precio = Utils.ToDecimal(PrecioTextBox.Text);
            decimal importe = Convert.ToDecimal(cantidad) * precio;


            if (DetalleGridView.Rows.Count > 0)
            {
                for (int i = 0; i < ((Facturas)ViewState["Detalle"]).Detalle.Count; i++)
                {
                    if (((Facturas)ViewState["Detalle"]).Detalle[i].ProductoId ==
                        Utils.ToInt(ProductoDropDownList.SelectedValue.ToString()))
                    {
                        ((Facturas)ViewState["Detalle"]).Detalle[i].Cantidad =
                        ((Facturas)ViewState["Detalle"]).Detalle[i].Cantidad
                         + Utils.ToInt(CantidadTextBox.Text.ToString());
                        ((Facturas)ViewState["Detalle"]).Detalle[i].Importe =
                        ((Facturas)ViewState["Detalle"]).Detalle[i].Cantidad
                      * ((Facturas)ViewState["Detalle"]).Detalle[i].Precio;
                        paso = true;
                        break;
                    }
                }
                if (!paso)
                {
                    if (ventaAnt == null)
                    {
                        facturas = (Facturas)ViewState["Detalle"];
                        facturas.AgregarDetalle(Utils.ToInt(FacturaIdTextBox.Text), Utils.ToInt(FacturaIdTextBox.Text), Utils.ToInt(ProductoDropDownList.SelectedValue), cantidad, precio, importe);
                    }
                    else
                    {
                        Utils.ShowToastr(this, "Agregado", "Exito!!", "info");
                        ventaAnt = (Facturas)ViewState["Detalle"];
                        ventaAnt.AgregarDetalle(Utils.ToInt(FacturaIdTextBox.Text), Utils.ToInt(FacturaIdTextBox.Text), Utils.ToInt(ProductoDropDownList.SelectedValue), cantidad, precio, importe);
                    }

                }
            }
            else
            {
                if (ventaAnt == null)
                {

                    facturas = (Facturas)ViewState["Detalle"];
                    facturas.AgregarDetalle(0, Utils.ToInt(FacturaIdTextBox.Text), Utils.ToInt(ProductoDropDownList.SelectedValue), cantidad, precio, importe);

                }
                else
                {
                    Utils.ShowToastr(this, "Agregado", "Exito!!", "info");
                    ventaAnt = (Facturas)ViewState["Detalle"];
                    ventaAnt.AgregarDetalle(0, Utils.ToInt(FacturaIdTextBox.Text), Utils.ToInt(ProductoDropDownList.SelectedValue), cantidad, precio, importe);
                }
            }

            ViewState["Facturas"] = facturas;
            DetalleGridView.DataSource = ((Facturas)ViewState["Detalle"]).Detalle;
            DetalleGridView.DataBind();
            SubTotal();
        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            DetalleVentas repositorio = new DetalleVentas();

            Facturas facturas = LlenarClase();

            if (Utils.ToInt(FacturaIdTextBox.Text) == 0)
            {

                paso = repositorio.Guardar(facturas);
                Limpiar();
                Utils.ShowToastr(this, "GUARDADO", "Success", "success");
            }
            else
            {
                Limpiar();
                paso = repositorio.Modificar(facturas);
                Utils.ShowToastr(this, "Modificado", "Info", "info");
            }
        }

        protected void eliminarutton_Click(object sender, EventArgs e)
        {
            DetalleVentas repositorio = new DetalleVentas();
            Facturas facturas = repositorio.Buscar(Utils.ToInt(FacturaIdTextBox.Text));

            if (facturas != null)
            {
                repositorio.Eliminar(facturas.FacturaId);
                Utils.ShowToastr(this, "Registro eliminado", "Exito", "success");
                Limpiar();
            }
            else
            {
                Utils.ShowToastr(this, "Error al   eliminr", "Error", "error");

                Limpiar();
            }
        }
        protected void ProductoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Precio();
            ImporteTextBox.Text = Calculos.Importe(Utils.ToDecimal(PrecioTextBox.Text), Utils.ToDecimal(CantidadTextBox.Text)).ToString();
        }
        protected void CantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            Precio();
            ImporteTextBox.Text = Calculos.Importe(Utils.ToDecimal(PrecioTextBox.Text), Utils.ToDecimal(CantidadTextBox.Text)).ToString();
        }

        private string SubTotal()
        {
            decimal total = 0;
            foreach (var item in ((Facturas)ViewState["Detalle"]).Detalle)
            {
                total += Calculos.CalcularSubTotal(Convert.ToDecimal(item.Importe));

            }
            return TotalTextBox.Text = total.ToString();
        }

        protected void ImporteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ImporteTextBox.Text != " ")
                TotalTextBox.Text = Calculos.CalcularSubTotal(Utils.ToDecimal(ImporteTextBox.Text)).ToString();
            else
                TotalTextBox.Text = " ";
        }

        private void Precio()
        {
            Productos productos = new Productos();
            int id = Utils.ToInt(ProductoDropDownList.SelectedValue);
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            productos = repositorio.Buscar(id);

            decimal prec = 0;
            prec = productos.Precio;

            PrecioTextBox.Text = prec.ToString();
        }

        protected void DetalleGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            row = Utils.ToIntObjetos(DetalleGridView.SelectedDataKey.Value);
        }

        protected void removerButton_Click(object sender, EventArgs e)
        {
            //DetalleGridView.DataSource = ViewState["Detalle"];
            //if (Utils.ToInt(FacturaIdTextBox.Text) == 0)
            //{
            //    list = (List<FacturasDetalles>)DetalleGridView.DataSource;
            //    Button btn = (Button)sender;
            //    GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            //    int indexdeboton = gvr.RowIndex;
            //    list.RemoveAt(indexdeboton);
            //    DetalleGridView.DataSource = ViewState["Detalle"];
            //    DetalleGridView.DataBind();
            //    LlenaValores();
            //}
            //else
            //{
            //    list = Metodos.ListaDetalle(Utils.ToInt(FacturaIdTextBox.Text));
            //    list.RemoveAt(row);
            //    DetalleGridView.DataSource = list;
            //    DetalleGridView.DataBind();
            //    LlenaValores();
            //}
        }
    }
}
    
