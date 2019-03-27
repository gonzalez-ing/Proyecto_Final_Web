using Proyecto_Final_Aplicada.DAL;
using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleVentas : RepositorioBase<Facturas>
    {
        public override Facturas Buscar(int id)
        {
            Facturas facturas = new Facturas();
            Contexto contexto = new Contexto();

            try
            {
                facturas = contexto.factura.Find(id);

                if (facturas != null)
                {
                    facturas.Detalle.Count();
                    foreach (var item in facturas.Detalle)
                    {
                        string p = item.producto.Nombre;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return facturas;
        }

        public override List<Facturas> GetList(Expression<Func<Facturas, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Facturas> lista = new List<Facturas>();
            try
            {
                lista = contexto.factura.Where(expression).ToList();
                foreach (var item in lista)
                {
                    item.Detalle.Count();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public override bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Facturas facturas = contexto.factura.Find(id);

                foreach (var item in facturas.Detalle)
                {
                    contexto.producto.Find(item.ProductoId).Inventario += item.Cantidad;

                }
                contexto.factura.RemoveRange(contexto.factura.Where(d => d.FacturaId == id));
                contexto.factura.Remove(facturas);
                contexto.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;
        }

        public override bool Modificar(Facturas facturas)
        {
            bool paso = false;
            try
            {
                //buscar las entidades que no estan para removerlas
                var Anterior = _contexto.factura.Find(facturas.FacturaId);
                foreach (var item in Anterior.Detalle)
                {
                   if (!facturas.Detalle.Exists(d => d.Id == item.Id))
                    {
                       item.producto = null;
                        _contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                //recorrer el detalle
                foreach (var item in facturas.Detalle)
                {
                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    _contexto.Entry(item).State = estado;
                }

                //Idicar que se esta modificando el encabezado
                _contexto.Entry(facturas).State = EntityState.Modified;

                if (_contexto.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


    }
}
