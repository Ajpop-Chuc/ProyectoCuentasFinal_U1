using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentas_Unidad1_
{
    internal class ClassMovimientosAux
    {
        string cuenta;
        double debe;
        double haber;

        public string Cuenta { get => cuenta; set => cuenta = value; }
        public double Debe { get => debe; set => debe = value; }
        public double Haber { get => haber; set => haber = value; }
    }
}
