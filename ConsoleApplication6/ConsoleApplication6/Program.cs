using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            NIF nif = new NIF(500489472);
            Persona p = new Persona();
            Fecha fecha = new Fecha(27,10,2018);
            Console.WriteLine(nif.calcularLetra());
            p.escribirDatos();
            p.longitud();
            fecha.escribirFL();
        }
    }
}
