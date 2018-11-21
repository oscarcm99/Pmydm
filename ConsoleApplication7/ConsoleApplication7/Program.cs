using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 teatro = new Class1(100);
            int opcion = 0;
            float recaudacion = 0;
            string categoria;
            do
            {
                Console.WriteLine("1. Vender entrada.");
                Console.WriteLine("2. Ver plazas ocupadas de cada categoría.");
                Console.WriteLine("3. Ver plazas libres.");
                Console.WriteLine("4. Ver recaudacion.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("Introduce opcion: ");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1:
                        Console.WriteLine("Introduce categoria: ");
                        categoria = Console.ReadLine();
                        teatro.venderEntrada(categoria);
                        break;
                    case 2:
                        teatro.asientosOcupados();
                        break;
                    case 3:
                        teatro.asientosLibres();
                        break;
                    case 4:
                        Console.WriteLine("La caja es: "+teatro.verRecaudacion(ref recaudacion)+" €");
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Introduce otra opcion: ");
                        break;
                }
            } while (opcion != 5);
        }
    }
}
