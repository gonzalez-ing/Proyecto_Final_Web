using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Aplicada.Entidades
{
    public class FacturasDetalles
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public FacturasDetalles()
        {
            Id = 0;
            FacturaId = 0;
        }

        public FacturasDetalles(int id, int facturaId, int productoId, int cantidad, decimal precio, decimal importe)
        {
            this.Id = id;
            this.FacturaId = facturaId;
            this.ProductoId = productoId;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe = importe;
            
        }

        public FacturasDetalles(int id, int facturaId, int usuarioId, int productoId, int cantidad, decimal precio, decimal importe)
        {

            this.Id = 0;
            this.FacturaId = 0;
            this.ProductoId = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Importe = 0;
        }
    }
}
