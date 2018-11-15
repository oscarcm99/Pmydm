using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class NIF
    {
        private UInt32 numero;
        public NIF(UInt32 numero) {
            this.numero = numero;
        }
        public UInt32 Numero {
            get { return numero; }
            set { numero = value; }
        }
        public char calcularLetra() {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            char[] letra = letras.ToCharArray();
            int resto = (int)numero % 23;
            return letra[resto];
        }
    }
}
