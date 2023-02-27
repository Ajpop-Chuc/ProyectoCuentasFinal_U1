using ProyectoCuentas_Unidad1_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCuentasFinal_U1
{
    public partial class FormMayor : Form
    {
        public FormMayor()
        {
            InitializeComponent();
        }

        private void FormMayor_Load(object sender, EventArgs e)
        {
            //carga de json
            ClassCuentasAC.listaActivosCorrientes.Clear();
            ClassCuentasANC.listaActivosNoCorrientes.Clear();
            ClassCuentasPC.listaPasivosCorrientes.Clear();
            ClassCuentasPNC.listaPasivosNoCorrientes.Clear();
            ClassMovimientos.listaMovimientos.Clear();
            ClassLibroMayor.listalibromayor.Clear(); //carga del json del libro mayor

            ClassCuentasAC.leerJson();
            ClassCuentasANC.leerJson();
            ClassCuentasPC.leerJson();
            ClassCuentasPNC.leerJson();
            ClassMovimientos.leerJson();
            ClassLibroMayor.leerJson();   //lectura del json del libro mayor

            ClassLibroMayor libromayor = new ClassLibroMayor(); //in the button
            double sumaDebe = 0;
            double sumaHaber = 0;
            int contador = 0;

            foreach (var x in ClassLibroMayor.listalibromayor)
            {
                contador++;
                listViewlibromayor.Items.Add(contador.ToString());
                listViewlibromayor.Items.Add(x.nombre);
                listViewlibromayor.Items.Add("");
                listViewlibromayor.Items.Add("");

                foreach (var i in x.ListaDebe)
                {
                    listViewlibromayor.Items.Add("");
                    listViewlibromayor.Items.Add("");
                    listViewlibromayor.Items.Add(i.ToString());
                    listViewlibromayor.Items.Add("");
                    sumaDebe+= i;
                }
                listViewlibromayor.Items.Add("");
                listViewlibromayor.Items.Add("");
                listViewlibromayor.Items.Add(sumaDebe.ToString());
                listViewlibromayor.Items.Add("");

            }
            //recorrido del debe
            foreach (var x in ClassLibroMayor.listalibromayor)
            {
                listViewlibromayor2.Items.Add("");

                foreach (var i in x.ListaHaber)
                {
                    listViewlibromayor2.Items.Add(i.ToString());
                    sumaHaber+= i;
                }
                listViewlibromayor2.Items.Add(sumaHaber.ToString());
            }
        }
    }
}
