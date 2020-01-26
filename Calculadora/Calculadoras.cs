using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadoras
    {
        const decimal porcentaje = 0.16m;
        public decimal ObtenerIva(decimal montoReserva)
        {
            return porcentaje * montoReserva;
        }
        public decimal ObtenerISH(decimal montoReserva, decimal porcentaje)
        { 
            return montoReserva * porcentaje;
        }
    }
}
