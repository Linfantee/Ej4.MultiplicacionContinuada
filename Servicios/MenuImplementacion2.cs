using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.MultiplicacionContinuada.Servicios
{
    internal class MenuImplementacion2 : MenuInterfaz2
    {

        public long numero()
        {
            long valor;
            Console.WriteLine("Introduzca un nuevo valor");
            valor = Convert.ToInt64(Console.ReadLine());

            return valor;
        }


        public string repetir()
        {
            string resultado = "";
            Console.WriteLine("Pulse s para continuar sino pulse n");
            resultado = Console.ReadLine();
            return resultado;
        }
    }
}
