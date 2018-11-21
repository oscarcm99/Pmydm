using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Class1
    {
        private int capacidadTotal;
        private int capacidadPatio, capacidadPlatea, capacidadPalco;
        private int ocupPatio, ocupPlatea, ocupPalco;
        private float precioEstandar, precioPlatea, precioPalco, recaudacion;

        public Class1(int total) {
            capacidadTotal = total;
            capacidadPatio = (20 * total) / 100;
            capacidadPlatea = (50 * total) / 100;
            capacidadPalco = (30 * total) / 100;
            ocupPatio = 0;
            ocupPlatea = 0;
            ocupPalco = 0;
            precioEstandar = 10;
            precioPlatea = precioEstandar * (0.9F);
            precioPalco = precioPlatea * (0.9F);
            recaudacion = 0;
        }

        public void venderEntrada(string categoria) {
            if (capacidadTotal != 0) {
                if (categoria == "Patio") {
                    if (capacidadPatio != 0)
                    {
                        capacidadTotal--;
                        capacidadPatio--;
                        ocupPatio++;
                        recaudacion += precioEstandar;
                    }
                    else
                        Console.WriteLine("No quedan entradas de patio");
                }
                if (categoria == "Platea")
                {
                    if (capacidadPlatea != 0) {
                        capacidadTotal--;
                        capacidadPlatea--;
                        ocupPlatea++;
                        recaudacion += precioPlatea;
                    } else
                        Console.WriteLine("No quedan entradas de platea");
                }
                if (categoria == "Palco")
                {
                    if (capacidadPatio != 0)
                    {
                        capacidadTotal--;
                        capacidadPalco--;
                        ocupPalco++;
                        recaudacion += precioPalco;
                    }
                    else
                        Console.WriteLine("No quedan entradas de palco");
                }
            }
            else {
                Console.WriteLine("No hay entradas disponibles.");
            }
        }
        public void asientosOcupados() {
            Console.WriteLine("Patio: " + ocupPatio + " plazas ocupados.");
            Console.WriteLine("Platea: " + ocupPlatea + " plazas ocupados.");
            Console.WriteLine("Palco: " + ocupPalco + " plazas ocupados.");
        }
        public void asientosLibres() {
            Console.WriteLine("Asientos libres: " + capacidadTotal + " plazas libres");
        }
        public float verRecaudacion(ref float totalcaja){
            totalcaja = recaudacion;
            return totalcaja;
        }
    }
}

