using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante();
            float cantidad = 0;
            int opcion = 0, numeroMesa = 0, nPersonas ;
            
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1. Ocupar mesa.");
                Console.WriteLine("2. Apuntar mesa.");
                Console.WriteLine("3. Cobrar mesa.");
                Console.WriteLine("4. Reservar mesa.");
                Console.WriteLine("5. Anular reserva mesa.");
                Console.WriteLine("6. Mostrar caja.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Introduce opcion");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        Console.WriteLine("Numero de mesa:");
                        numeroMesa = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Numero de personas:");
                        nPersonas = Int32.Parse(Console.ReadLine());
                        restaurante.ocupar(numeroMesa, nPersonas, DateTime.Now);
                        break;
                    case 2:
                        Console.WriteLine("Numero de mesa:");
                        numeroMesa = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Cantidad:");
                        cantidad = (float)Double.Parse(Console.ReadLine());
                        restaurante.apuntar(numeroMesa, cantidad);
                        break;
                    case 3:
                        Console.WriteLine("Numero de mesa:");
                        numeroMesa = Int32.Parse(Console.ReadLine());
                        restaurante.cobrar(numeroMesa);
                        break;
                    case 4:
                        Console.WriteLine("Numero de mesa:");
                        numeroMesa = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Numero de personas:");
                        nPersonas = Int32.Parse(Console.ReadLine());
                        restaurante.reservar(numeroMesa,nPersonas,DateTime.Now);
                        break;
                    case 5:
                        Console.WriteLine("Numero de mesa:");
                        numeroMesa = Int32.Parse(Console.ReadLine());
                        restaurante.anular(numeroMesa);
                        break;
                    case 6:
                        Console.WriteLine("La recaudacion total de la cja es: " + restaurante.recaudadocaja());
                        break;
                }
            } while (opcion != 7);
        }
    }
}
