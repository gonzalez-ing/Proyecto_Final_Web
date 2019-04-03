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

        public static decimal CalcularGanancias(decimal precio, decimal costo)
        {
            decimal ganancia = (precio - costo);
            decimal margen = (ganancia / precio) * 100;

            return decimal.Round(margen, 2);
        }


    }
}
