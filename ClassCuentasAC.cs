using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentasFinal_U1
{
    internal class ClassCuentasAC
    {
        public string nombre;
        public double saldo;
        public static List<ClassCuentasAC> listaActivosCorrientes = new List<ClassCuentasAC>();

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listaActivosCorrientes);
            System.IO.File.WriteAllText("CuentasAC.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("CuentasAC.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaActivosCorrientes = JsonConvert.DeserializeObject<List<ClassCuentasAC>>(json);
        }
    }
}
