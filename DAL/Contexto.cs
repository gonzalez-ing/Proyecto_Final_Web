using Proyecto_Final_Aplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Aplicada.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Productos> producto { get; set; }
        public DbSet<EntradaProductos> entrada { get; set; }
        public DbSet<Facturas> factura { get; set; }
        public DbSet<FacturasDetalles> FacturaDetalle { get; set; }

        public Contexto() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    } 
}