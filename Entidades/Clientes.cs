using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Aplicada.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }



        public Clientes(int Clienteid, string nombre, string cedula, string direccion, string telefono, DateTime fecha)
        {
            this.ClienteId = Clienteid;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Fecha = fecha;        }

        public Clientes()
        {
            this.ClienteId = 0;
            this.Nombre = string.Empty;
            this.Cedula = string.Empty;
            this.Telefono = string.Empty;
            this.Fecha = DateTime.Now;
 
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
