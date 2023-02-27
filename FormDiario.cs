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
    public partial class FormDiario : Form
    {
        public FormDiario()
        {
            InitializeComponent();
        }

       
        private void FormDiario_Load(object sender, EventArgs e)
        {
            //carga de json
            ClassCuentasAC.listaActivosCorrientes.Clear();
            ClassCuentasANC.listaActivosNoCorrientes.Clear();
            ClassCuentasPC.listaPasivosCorrientes.Clear();
            ClassCuentasPNC.listaPasivosNoCorrientes.Clear();
            ClassMovimientos.listaMovimientos.Clear();

            ClassCuentasAC.leerJson();
            ClassCuentasANC.leerJson();
            ClassCuentasPC.leerJson();
            ClassCuentasPNC.leerJson();
            ClassMovimientos.leerJson();

            ClassMovimientosAux listaCuentasInvolucradas = new ClassMovimientosAux();
            double sumaDebe = 0;
            double sumaHaber = 0;
            int contador = 0;

            foreach (var x in ClassMovimientos.listaMovimientos)
            {
                sumaDebe = 0;
                sumaHaber = 0;
                contador++;
                listViewlibroDiario.Items.Add(contador.ToString());
                listViewlibroDiario.Items.Add("");
                listViewlibroDiario.Items.Add("");
                listViewlibroDiario.Items.Add("");

                foreach (var i in x.listaCuentasInvolucradas)
                {
                    listViewlibroDiario.Items.Add("");
                    listViewlibroDiario.Items.Add(i.Cuenta.ToString());
                    listViewlibroDiario.Items.Add(i.Debe.ToString());
                    listViewlibroDiario.Items.Add(i.Haber.ToString());
                    sumaDebe += i.Debe;
                    sumaHaber += i.Haber;

                }
                listViewlibroDiario.Items.Add("Cuadre");
                listViewlibroDiario.Items.Add("");
                listViewlibroDiario.Items.Add(sumaDebe.ToString());
                listViewlibroDiario.Items.Add(sumaHaber.ToString());
                
            }


        }
    }

}
