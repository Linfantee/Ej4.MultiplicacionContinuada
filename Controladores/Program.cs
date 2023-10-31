using Ej4.MultiplicacionContinuada.Servicios;

namespace Ej4.MultiplicacionContinuada 
{
    class Program 
    { 
       public static void Main(string[] args) 
       {

            string resultado;
            long numero;

            MenuInterfaz aka = new MenuImplementacion();
            MenuInterfaz2 ao = new MenuImplementacion2();

            do
            {
                numero = ao.numero();
                aka.multiplicacion(numero);
                resultado = ao.repetir();

            } while (resultado == "s");
        
        
        
       } 
       
    }

}



