using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa[] mesa = new Mesa[4];
            mesa[0] = new Mesa();
            mesa[1] = new Mesa(8, 4, "Ocupada", "13:00");
            mesa[2] = new Mesa(8, 0, "Reservada", "14:30");
            mesa[3] = new Mesa(8, 4, "Ocupada", "14:00");
            double precio = 0,cantidad = 0;
            int opcion = 0;
            do
            {
                Console.WriteLine("1. Conocer numeros de plazas libres.");
                Console.WriteLine("2. Conocer el numero de plazas ocupadas.");
                Console.WriteLine("3. Conocer la caja");
                Console.WriteLine("4. Conocer la cantidad  que falta por cobrar");
                Console.WriteLine("5. Lista actual");
                Console.WriteLine("Introduce una opcion: ");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < mesa.Length; i++)
                            Console.WriteLine("En la mesa " + (i + 1) + " hay " + (mesa[i].Ocupmax - mesa[i].Ocupact) + " plazas libres");
                        break;
                    case 2:
                        for (int i = 0; i < mesa.Length; i++)
                            Console.WriteLine("En la mesa " + (i + 1) + " hay " + mesa[i].Ocupact + " plazas ocupadas");
                        break;
                    case 3:
                        for (int i = 0; i < mesa.Length; i++)
                        {
                            precio = cobrarMesa(mesa[i], 'T');
                            cantidad += precio;
                        }
                        Console.WriteLine(cantidad+" euros");
                        break;
                    case 4:
                        break;
                    case 5:
                        for (int i = 0; i < mesa.Length; i++)
                            Console.WriteLine(mesa[i].Ocupmax + " " + mesa[i].Ocupact + " " + mesa[i].EstadoMesa + " " + mesa[i].Hora);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
            while (opcion != 6);
        }
        public static double cobrarMesa(Mesa mesa, char mp){
            double precio = 0;
            if (mesa.Ocupact > 0)
            {
                precio = mesa.Ocupact * 10;
                mesa = new Mesa();
                return precio;
            }
            else
                return 0;
        }
    }
   }
