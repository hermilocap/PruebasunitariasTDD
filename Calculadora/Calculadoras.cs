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
            //const decimal porcentaje = 0.16m;
            //decimal ivareserva = porcentaje * montoReserva;
            //return ivareserva;
            return porcentaje * montoReserva;
        }
    }
}
