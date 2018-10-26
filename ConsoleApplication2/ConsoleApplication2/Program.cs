using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void escribirMenu() {
            Console.WriteLine("1. Inicializar la variable.",
                "2. Rellenar la cadena.",
                "3. Escribir la cadena por pantalla",
                "4. Invertir la cadena.",
                "5. Convertir la cadena a mayusculas.",
                "6. Convertir la cadena a minusculas. ",
                "7. Rotar caracter a la derecha.",
                "8. Rotar caracter a la izquierda",
                "9. Salir del programa.",
                "Introduce una opcion: ");
        }
        static void iniciarCadena(String cadena) {
            cadena = "\0";
        }
        static void introducirCadena(ref String cadena){
            Console.WriteLine("Introduce la palabra: ");
            cadena = Convert.ToString(Console.ReadLine());
        }
        static void escribirCadena(String cadena) {
            Console.WriteLine("La palabra es: " + cadena);
        }
        static void invertirCadena(String cadena) {
            for (int i = cadena.Length; i >= 0; i++)
                cadena += cadena[i];
        }
        static void convertirMayusculas(String cadena){
            cadena = cadena.ToUpperInvariant();
        }
        static void convertirMinusculas(String cadena)
        {
            cadena = cadena.ToLowerInvariant();
        }
        static void rotarDerecha(String cadena) {
            int contador = 0;
            while (contador < cadena.Length)
            {
                cadena += cadena[contador % cadena.Length+1];
                contador++;
            }

               
        }
        static void rotarIzquierda(String cadena) {
        }
        static void Main(string[] args)
        {
            String cadena =  null;
            int opcion = 0;
            
            while (opcion != 9)
            {
                escribirMenu();
                opcion = Convert.ToInt32(Console.ReadKey());
                switch (opcion)
                {
                    case 1:
                        iniciarCadena( cadena);
                        break;
                    case 2:
                        introducirCadena(ref cadena);
                        break;
                    case 3:
                        escribirCadena(cadena);
                        break;
                    case 4:
                        invertirCadena(cadena);
                        break;
                    case 5:
                        convertirMayusculas(cadena);
                        break;
                    case 6:
                        convertirMinusculas(cadena);
                        break;
                    case 7:
                        rotarDerecha(cadena);
                        break;
                    case 8:
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        
    }
}
