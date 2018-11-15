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
        public static decimal metodoUno(decimal num) {
            num = Math.Truncate(num);
            return num;
        }
        public static int metodoDos(decimal num, int numfin) {
            numfin = Convert.ToInt32(Math.Truncate(num));
            return numfin;
        }
        public static void metodoTres(decimal num) {
            Console.WriteLine(Math.Truncate(num));
        }
        public static decimal metodoCuatro(decimal num, int limit) {
            num = Decimal.Round(num, limit);
            return num;
        }
        public static void metodoCinco(decimal numinicial, int limit, decimal numfinal){
            numfinal = Decimal.Round(numinicial,limit);
            Console.WriteLine(numfinal);
        }
        public static void metodoSeis(decimal num, int limit){
            num = Decimal.Round(num,limit);
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            decimal numero = 0;
            int numeroTruncado = 0;
            while (opcion != 7)
            {
                escribirMenu();
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        numero = metodoUno(4.32m);
                        Console.WriteLine(numero); 
                        break;
                    case 2:
                        numeroTruncado = metodoDos(4.32m, numeroTruncado);
                        Console.WriteLine(numeroTruncado);
                        break;
                    case 3:
                        metodoTres(4.32m);
                        break;
                    case 4:
                        numero = metodoCuatro(4.3244m, 2);
                        Console.WriteLine(numero);
                        break;
                    case 5:
                        metodoCinco(4.3244m,1,numero);
                        break;
                    case 6:
                        metodoSeis(4.3244m,3);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Introduce otra opcion");
                        break;

                }
            }        
        }
    }
    }
