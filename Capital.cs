using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentasFinal_U1
{
    internal class Capital
    {
        public string nombre;
        public double saldo;
        public static List<Capital> listaCuentasCapital = new List<Capital>();

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listaCuentasCapital);
            System.IO.File.WriteAllText("CuentasCapital.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("CuentasCapital.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaCuentasCapital = JsonConvert.DeserializeObject<List<Capital>>(json);
        }
    }
}
        