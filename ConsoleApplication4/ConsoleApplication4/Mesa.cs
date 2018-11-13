using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Mesa
    {
        private int ocupmax;
        private int ocupact;
        private String estadoMesa;
        private String hora;
        public Mesa(int ocupmax, int ocupact, String estadoMesa, String hora) {
            this.ocupmax = ocupmax;
            this.ocupact = ocupact;
            this.estadoMesa = estadoMesa;
            this.hora = hora;
        }
        public Mesa() {
            this.ocupmax = 8;
            this.ocupact = 0;
            this.estadoMesa = "Libre";
            this.hora = ""; 
        }
        public int Ocupmax {
            get { return ocupmax; }
            set { ocupmax = value; }
        }
        public int Ocupact {
            get { return ocupact; }
            set { ocupact = value; }
        }
        public String EstadoMesa{
            get { return estadoMesa; }
            set { estadoMesa = value; }
        }
        public String Hora{
            get { return hora; }
            set { hora = value; }
        }
    }
}
