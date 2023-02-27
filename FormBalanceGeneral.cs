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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoCuentasFinal_U1
{
    public partial class FormBalanceGeneral : Form
    {
        public FormBalanceGeneral()
        {
            InitializeComponent();

        }

        private void FormBalanceGeneral_Load(object sender, EventArgs e)
        {
            ClassCuentasAC.listaActivosCorrientes.Clear();
            ClassCuentasANC.listaActivosNoCorrientes.Clear();
            ClassCuentasPC.listaPasivosCorrientes.Clear();
            ClassCuentasPNC.listaPasivosNoCorrientes.Clear();
            ClassMovimientos.listaMovimientos.Clear();
            Capital.listaCuentasCapital.Clear();

            ClassCuentasAC.leerJson();
            ClassCuentasANC.leerJson();
            ClassCuentasPC.leerJson();
            ClassCuentasPNC.leerJson();
            ClassMovimientos.leerJson();
            Capital.leerJson(); 

            double totalAC = 0;
            double totalANC = 0;
            double totalPC = 0;
            double totalPNC = 0;
            double totalCapital = 0;
            double saldomod = 0;
            double SumaActivos = 0;
            double SumaPasivos = 0;   

            foreach (ClassCuentasAC cuenta in ClassCuentasAC.listaActivosCorrientes)
            {
                listViewAC.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                { 
                    listViewAC.Items.Add((cuenta.saldo).ToString());
                    totalAC += cuenta.saldo;
                }
                else
                {
                    saldomod = cuenta.saldo * -1;
                    listViewAC.Items.Add((saldomod).ToString());
                    totalAC += saldomod;
                }
                

            }
            listViewAC.Items.Add("Total");
            listViewAC.Items.Add(totalAC.ToString());

            foreach(ClassCuentasANC cuenta in ClassCuentasANC.listaActivosNoCorrientes)
            {
                listViewANC.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewANC.Items.Add((cuenta.saldo).ToString());
                    totalANC += cuenta.saldo;
                }
                else
                {
                    saldomod = cuenta.saldo * -1;
                    listViewANC.Items.Add((saldomod).ToString());
                    totalANC += saldomod;
                }
               

            }
            listViewANC.Items.Add("Total");
            listViewANC.Items.Add(totalANC.ToString());

            foreach (ClassCuentasPC cuenta in ClassCuentasPC.listaPasivosCorrientes)
            {
                listViewPC.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewPC.Items.Add((cuenta.saldo).ToString());
                    totalPC += cuenta.saldo;
                }
                else
                {
                    saldomod = cuenta.saldo * -1;
                    listViewPC.Items.Add((saldomod).ToString());
                    totalPC += saldomod;
                }
                

            }
            listViewPC.Items.Add("Total");
            listViewPC.Items.Add(totalPC.ToString());


            foreach (ClassCuentasPNC cuenta in ClassCuentasPNC.listaPasivosNoCorrientes)
            {
                listViewPNC.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewPNC.Items.Add((cuenta.saldo).ToString());
                    totalPNC += cuenta.saldo;
                }
                else
                {
                    saldomod = cuenta.saldo * -1;
                    listViewPNC.Items.Add((saldomod).ToString());
                    totalPNC += saldomod;
                }
              

            }
            listViewPNC.Items.Add("Total");
            listViewPNC.Items.Add(totalPNC.ToString());

            foreach (Capital cuenta in Capital.listaCuentasCapital)
            {
                listViewCapital.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewCapital.Items.Add((cuenta.saldo).ToString());
                    totalCapital += cuenta.saldo;
                }
                else
                {
                    saldomod = cuenta.saldo * -1;
                    listViewCapital.Items.Add((saldomod).ToString());
                    totalCapital += saldomod;
                }


            }
            listViewCapital.Items.Add("Total");
            listViewCapital.Items.Add(totalCapital.ToString());

            SumaPasivos = totalPC + totalPNC + totalCapital;
            SumaActivos = totalAC + totalANC;
            label6.Text += SumaActivos;
            label7.Text += SumaPasivos;
        }
    } 
}
