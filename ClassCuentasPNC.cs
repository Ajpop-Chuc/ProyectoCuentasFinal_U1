using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentas_Unidad1_
{
    internal class ClassCuentasPNC
    {
        public string nombre;
        public double saldo;
        public static List<ClassCuentasPNC> listaPasivosNoCorrientes = new List<ClassCuentasPNC>();

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listaPasivosNoCorrientes);
            System.IO.File.WriteAllText("CuentasPNC.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("CuentasPNC.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaPasivosNoCorrientes = JsonConvert.DeserializeObject<List<ClassCuentasPNC>>(json);
        }
    }
}
