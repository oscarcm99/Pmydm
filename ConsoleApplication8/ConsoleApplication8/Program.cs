using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void rellenarCadena(ref string cadena)
        {
            Console.WriteLine("Escribe una palabra: ");
            cadena = Console.ReadLine();
        }
        static void rotarDerecha(ref string cadena, int n) {
            var array = cadena.ToCharArray();
            char[] palabra = new Char[cadena.Length];
            do
            {
                for (int i = 0; i < array.Length; i++)
                    if (i != 0)
                        palabra[i] = array[i - 1];
                    else
                        palabra[i] = array[array.Length-1];
                n--;
            } while (n != 0);
            cadena = Convert.ToString(palabra);
        }
        static void rotarIzquierda(ref string cadena, int n)
        {
            var array = cadena.ToCharArray();
            char[] palabra = new Char[cadena.Length];
            do
            {
                for (int i = 0; i < array.Length; i++)
                    if (i != 0)
                        palabra[i] = array[i + 1];
                    else
                        palabra[array.Length - 1] = array[i];
                n--;
            } while (n != 0);
            cadena = Convert.ToString(palabra);
        }
        static void Main(string[] args)
        {
            string cadena = "";
            rellenarCadena(ref cadena);
            Console.WriteLine(cadena);
            rotarDerecha(ref cadena,2);
            Console.WriteLine(cadena);
            rotarIzquierda(ref cadena, 4);
            Console.WriteLine(cadena);

        }
    }
}
