using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Aplicada.Entidades
{
        public class Usuarios
        {
            [Key]
            public int UsuarioId { get; set; }
            public string Nombre { get; set; }
            public string Usuario { get; set; }
            public string Clave { get; set; }


        public override string ToString()
        {
            return this.Nombre;
        }

    }    
}
