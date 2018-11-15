using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Mesa
    {
        private int ocupantemax, ocupanteact;
        private string estadomesa;
        private float importe;
        private DateTime horafecha;

        public Mesa() {
            ocupantemax = 4;
            ocupanteact = 0;
            estadomesa = "Libre";
            importe = 0;
            horafecha = new DateTime(2018,1,1,10,30,00);
        }
        public Mesa(int ocupmax){
            ocupantemax = ocupmax;
            ocupanteact = 0;
            estadomesa = "Libre";
            importe = 0;
            horafecha = new DateTime(2018, 1, 1, 10, 30, 00);
        }
        public void ocupar(int nPersonas, DateTime horaocup) {
            if (((estadomesa=="Libre")|| (estadomesa == "Reservada")) && (nPersonas <= ocupantemax)){
                ocupanteact = nPersonas;
                estadomesa = "Ocupada";
                horafecha = horaocup;
            }
        }
        public void reservar(int nPersonas, DateTime horareserva) {
            if (nPersonas <= ocupantemax)
            {
                ocupanteact = nPersonas;
                estadomesa = "Reservada";
                horafecha = horareserva;
            }
        }
        public void anularReserva() {
            ocupanteact = 0;
            estadomesa = "Libre";
        }
        public void apuntar(float cantidad) {
            importe = importe + cantidad;
        }
        public void cobrar(ref float importetotal){
            importetotal = importetotal + importe;
            ocupanteact = 0;
            estadomesa = "Libre";
            importe = 0;
        }
    }
}
