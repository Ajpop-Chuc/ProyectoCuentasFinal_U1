using Newtonsoft.Json;
using ProyectoCuentasFinal_U1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCuentas_Unidad1_
{
    internal class ClassMovimientos
    {
        public List<ClassMovimientosAux> listaCuentasInvolucradas = new List<ClassMovimientosAux>();

        public static List<ClassMovimientos> listaMovimientos = new List<ClassMovimientos>();

        public static void guardarenJson()
        {
            string json = JsonConvert.SerializeObject(listaMovimientos);
            System.IO.File.WriteAllText("listaTodosLosMovimientos.Json", json);
        }
        public static void leerJson()
        {
            StreamReader jsonStream = File.OpenText("listaTodosLosMovimientos.Json");
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaMovimientos = JsonConvert.DeserializeObject<List<ClassMovimientos>>(json);
        }
    }
}
