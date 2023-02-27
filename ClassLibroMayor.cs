using Newtonsoft.Json;
using ProyectoCuentas_Unidad1_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentasFinal_U1
{
    internal class ClassLibroMayor
    {

        public static List<ClassLibroMayor> listalibromayor = new List<ClassLibroMayor>(); //falta arreglar
        public string nombre;
        public List<double> ListaDebe = new List<double>();
        public List<double> ListaHaber = new List<double>();

        

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listalibromayor);
            System.IO.File.WriteAllText("listaLibroMayor.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("listaLibroMayor.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listalibromayor = JsonConvert.DeserializeObject<List<ClassLibroMayor>>(json);
        }

    }
}
