using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Restaurante
    {
        private float cajatotal;
        private Mesa [] mesa = new Mesa[4];

        public Restaurante() {
            cajatotal = 0;
            mesa[0] = new Mesa();
            mesa[1] = new Mesa();
            mesa[2] = new Mesa(9);
            mesa[3] = new Mesa(9);
        }

        public void ocupar(int numeroMesa, int personas, DateTime hora) {
            mesa[numeroMesa].ocupar(personas,hora);
        }
        public void apuntar(int numeroMesa, float cantidad) {
            mesa[numeroMesa].apuntar(cantidad);
        }
        public void cobrar(int numeroMesa) {
            mesa[numeroMesa].cobrar(ref cajatotal);
        }
        public void reservar(int numeroMesa, int personas, DateTime horareserva) {
            mesa[numeroMesa].reservar(personas,horareserva);
        }
        public void anular(int numeroMesa) {
            mesa[numeroMesa].anularReserva();
        }
        public float recaudadocaja() {
            return cajatotal;
        }
    }
}
