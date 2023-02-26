using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentas_Unidad1_
{
    internal class ClassCuentasPC
    {
        public string nombre;
        public double saldo;
        public static List<ClassCuentasPC> listaPasivosCorrientes = new List<ClassCuentasPC>();

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listaPasivosCorrientes);
            System.IO.File.WriteAllText("CuentasPC.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("CuentasPC.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaPasivosCorrientes = JsonConvert.DeserializeObject<List<ClassCuentasPC>>(json);
        }

    }
}
