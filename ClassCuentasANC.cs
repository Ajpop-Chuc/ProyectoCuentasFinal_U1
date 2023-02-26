using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentas_Unidad1_
{
    internal class ClassCuentasANC
    {
        public string nombre;
        public double saldo;
        public static List<ClassCuentasANC> listaActivosNoCorrientes = new List<ClassCuentasANC>();

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listaActivosNoCorrientes);
            System.IO.File.WriteAllText("CuentasANC.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("CuentasANC.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaActivosNoCorrientes = JsonConvert.DeserializeObject<List<ClassCuentasANC>>(json);
        }
    }
}
