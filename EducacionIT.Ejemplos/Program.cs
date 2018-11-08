using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //PruebasCasteo();
            for (int j = 0; j < 500; j++)
            {
                for (int i = 0; i < 5000; i++)
                {
                    if (i == 50)
                    {
                        int error = i / 0;
                    }
                    Console.WriteLine("Iteracion " + i);
                }
            }
             

            Console.ReadKey();

        }

        private static void PruebasCasteo()
        {
            string cadena1 = "BLA";
            Console.WriteLine("cadena1: " + cadena1);
            //Conversion de datos Boxing / Upcast / Implicita
            object cadenaEnObject = cadena1;
            Console.WriteLine("cadenaEnObject: " + cadenaEnObject);
            //Conversion de datos Unboxing / Downcast / Explicita
            string cadenaDesdeObject = (string)cadenaEnObject;
            Console.WriteLine("cadenaDesdeObject: " + cadenaDesdeObject);

            //Con una conversion unboxing puedo tener errores de tipos de datos
            //object stringEnObject = "Cadena";
            //int unboxingConError = (int)stringEnObject;

            //Conversion "Cast"
            int entero = 32;
            string cadenaEntero = entero.ToString();
            Console.WriteLine("cadenaEntero: " + cadenaEntero);
            string cadenaEntero2 = "32";
            int enteroDesdeCadena = Convert.ToInt32(cadenaEntero2);
            Console.WriteLine("enteroDesdeCadena: " + enteroDesdeCadena);

            string noEsNumero = "Esto no es un numero";
            //int fallaPorqueNoEsNumero = Convert.ToInt32(noEsNumero);

            int numeroNoFalla;
            try
            {
                numeroNoFalla = Convert.ToInt32(noEsNumero);
            }
            catch
            {
                numeroNoFalla = -1;
            }
            Console.WriteLine("numeroNoFalla: " + numeroNoFalla);
        }
    }
}
