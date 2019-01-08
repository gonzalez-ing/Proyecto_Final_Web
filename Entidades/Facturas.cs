using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Aplicada.Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total { get; set; }

        public virtual ICollection<FacturasDetalles> Detalle { get; set; }

        public Facturas(int Facturaid, int clienteId, DateTime fecha, decimal subtotal, decimal itbis, decimal total, List<FacturasDetalles> detalle)
        {
            this.FacturaId = Facturaid;
            this.ClienteId = clienteId;
            this.Fecha = fecha;
            this.Subtotal = subtotal;
            this.ITBIS = itbis;
            this.Total = total;
            this.Detalle = detalle;
        }

        public Facturas()
        {
            this.FacturaId = 0;
            this.ClienteId = 0;
            this.Fecha = DateTime.Now;
            this.Subtotal = 0;
            this.ITBIS = 0;
            this.Total = 0;
            Detalle = new List<FacturasDetalles>();
        }

        public void AgregarDetalle(int id, int FacturaId, int ProductoId,  int cantidad, decimal precio, int importe)
        {
            this.Detalle.Add(new FacturasDetalles(id, FacturaId, ProductoId, cantidad, precio, importe));
        }
    }
}
