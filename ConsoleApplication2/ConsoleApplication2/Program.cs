using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena =  null;
            int opcion = 0;

            do {
                Console.WriteLine("1. Inicializar variable.");
                Console.WriteLine("2. Rellenar cadena.");
                Console.WriteLine("3. Escribir la cadena por pantalla.");
                Console.WriteLine("4. Invertir cadena.");
                Console.WriteLine("5. Convertir mayusculas.");
                Console.WriteLine("6. Convertir minúsculas.");
                Console.WriteLine("7. Rotar derecha.");
                Console.WriteLine("8. Rotar izquierda.");
                Console.WriteLine("9. Salir");
                Console.WriteLine("Introduce opcion: ");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        iniciarCadena(cadena);
                        break;
                    case 2:
                        rellenarCadena(ref cadena); 
                        break;
                    case 3:
                        escribirCadena(cadena);
                        break;
                    case 4:
                        cadena = invertirCadena(cadena);
                        break;
                    case 5:
                        cadena =convertirMayusculas(cadena);
                        break;
                    case 6:
                        cadena = convertirMinusculas(cadena);
                        break;
                    case 7:
                        cadena = rotarDerecha(cadena);
                        break;
                    case 8:
                        cadena = rotarIzquierda(cadena);
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (opcion!=9);
        }
        public static void iniciarCadena(string cadena) {
            cadena = "";
        }
        public static void rellenarCadena(ref string cadena) {
            cadena = Console.ReadLine();
        }
        public static void escribirCadena(string cadena) {
            Console.WriteLine(cadena);
        }
        public static string invertirCadena(string cadena) {
            char[] charArray = cadena.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string convertirMayusculas(string cadena) {
            cadena = cadena.ToUpper();
            return cadena;
        }
        public static string convertirMinusculas(string cadena) {
            cadena = cadena.ToLower();
            return cadena;
        }
        public static string rotarDerecha(string cadena){
            var arr = cadena.ToCharArray();
            char[] cad = new char[0x100];
            for (int i=0; i<arr.Length; i++) {
                if (i != 0)
                    cad[i] = arr[i - 1];
                else
                    cad[i] = arr[arr.Length - 1]; 
            }
            return new string(cad);
        }
        public static string rotarIzquierda(string cadena)
        {
            var arr = cadena.ToCharArray();
            char[] cad = new char[0x100];
            for ( int i = 0; i<arr.Length; i++){
                if (i != 0)
                    cad[i - 1] = arr[i];
                else
                    cad[arr.Length - 1] = arr[i];
            }
            return new string(cad);
        }
    }
}
