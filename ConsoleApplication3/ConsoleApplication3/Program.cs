using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static void escribirMenu()
        {
            Console.WriteLine("1. Metodo 1.");
            Console.WriteLine("2. Metodo 2.");
            Console.WriteLine("3. Metodo 3.");
            Console.WriteLine("4. Metodo 4.");
            Console.WriteLine("5. Metodo 5.");
            Console.WriteLine("6. Metodo 6.");
            Console.WriteLine("7. Salir.");
            Console.WriteLine("Introduce opción: ");
        }
        public static void metodoUno() {
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 7)
            {
                escribirMenu();
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;

                }
            }        
        }
    }
    }
