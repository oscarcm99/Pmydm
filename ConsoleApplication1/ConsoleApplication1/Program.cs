using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 23;
            Type tipo;
            if (128 is System.Int32)
                Console.WriteLine("Si es un numero");
            else
                Console.WriteLine("No es un numero");
            tipo = numero.GetType();
            Console.WriteLine("El tipo de datos es: "+tipo.ToString());
            Console.ReadKey();
        }
    }
}
