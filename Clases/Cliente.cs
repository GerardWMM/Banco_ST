using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int MontoCredito { get; set; }
        public int Cuotas { get; set; }

        public Cliente(string nombre, string apellido, int montoCredito, int cuotas)
        {
            Nombre = nombre;
            Apellido = apellido;
            MontoCredito = montoCredito;
            Cuotas = cuotas;
        }


    }
}
