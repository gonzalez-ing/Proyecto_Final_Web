using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Calculos
    {
        public static decimal Importe(decimal precio, decimal cantidad)
        {
            return precio * cantidad;
        }

        public static decimal CalcularSubTotal(decimal importe)
        {
            return importe;
        }

    }
}
