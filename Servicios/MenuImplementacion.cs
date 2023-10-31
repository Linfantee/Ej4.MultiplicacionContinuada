using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.MultiplicacionContinuada.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public long multiplicacion(long numero)
        {
            long n1 = 1;
            for (int i = 1; i <= numero; i++) 
            {
                n1 = n1 * i;
            }
            Console.WriteLine("La solución de la multiplicación es: " + n1);
            return n1;
        }

    }
}
