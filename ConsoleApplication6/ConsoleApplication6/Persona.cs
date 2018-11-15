using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;

        public Persona() {
            this.nombre = "Oscar";
            this.apellidos = "Calderon Moran";
            this.edad = 19;
        }
        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public string Nombre
        {
            get{ return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public void escribirDatos()
        {
            Console.WriteLine(Nombre+" "+Apellidos+" " + Edad);
        }
        public bool esMayor() {
            return (edad >= 18);
        }
        public void longitud() {
            Console.WriteLine("Longitud: "+Nombre.Length+" "+(Apellidos.Length-1));
        }
    }
}
