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
    public partial class FormBalanceSaldos : Form
    {
        public FormBalanceSaldos()
        {
            InitializeComponent();
        }

        private void FormBalanceSaldos_Load(object sender, EventArgs e)
        {
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

            double saldomod = 0;
            double totalDEBE = 0;
            double totalHABER = 0;
            double DEBE = 0;
            double HABER = 0;

            foreach (Capital cuenta in Capital.listaCuentasCapital)
            {
                listViewBS.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewBS.Items.Add((cuenta.saldo).ToString());
                    listViewBS.Items.Add("");
                    DEBE += cuenta.saldo; ;

                }
                else
                {
                    listViewBS.Items.Add("");
                    saldomod = cuenta.saldo * -1;
                    listViewBS.Items.Add((saldomod).ToString());
                    HABER += saldomod;

                }
            }


            foreach (ClassCuentasAC cuenta in ClassCuentasAC.listaActivosCorrientes)
            {
                listViewBS.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewBS.Items.Add((cuenta.saldo).ToString());
                    listViewBS.Items.Add("");
                    DEBE += cuenta.saldo; ;
                  
                }
                else
                {
                    listViewBS.Items.Add("");
                    saldomod = cuenta.saldo * -1;
                    listViewBS.Items.Add((saldomod).ToString());
                    HABER += saldomod;
                    
                }
            }

            foreach (ClassCuentasANC cuenta in ClassCuentasANC.listaActivosNoCorrientes)
            {
                listViewBS.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewBS.Items.Add((cuenta.saldo).ToString());
                    listViewBS.Items.Add("");
                    DEBE += cuenta.saldo;

                }
                else
                {
                    listViewBS.Items.Add("");
                    saldomod = cuenta.saldo * -1;
                    listViewBS.Items.Add((saldomod).ToString());
                    HABER += saldomod;

                }
            }

            foreach (ClassCuentasPC cuenta in ClassCuentasPC.listaPasivosCorrientes)
            {
                listViewBS.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewBS.Items.Add((cuenta.saldo).ToString());
                    listViewBS.Items.Add("");
                    DEBE += cuenta.saldo;   

                }
                else
                {
                    listViewBS.Items.Add("");
                    saldomod = cuenta.saldo * -1;
                    listViewBS.Items.Add((saldomod).ToString());
                    HABER += saldomod;
                }
            }

            foreach (ClassCuentasPNC cuenta in ClassCuentasPNC.listaPasivosNoCorrientes)
            {
                listViewBS.Items.Add(cuenta.nombre.ToString());
                if (cuenta.saldo >= 0)
                {
                    listViewBS.Items.Add((cuenta.saldo).ToString());
                    listViewBS.Items.Add("");
                    DEBE += cuenta.saldo;

                }
                else
                {
                    listViewBS.Items.Add("");
                    saldomod = cuenta.saldo * -1;
                    listViewBS.Items.Add((saldomod).ToString());
                    HABER += saldomod;      

                }
            }

            listViewBS.Items.Add("Sumas iguales");
            listViewBS.Items.Add(DEBE.ToString());
            listViewBS.Items.Add(HABER.ToString());

        }
    }
}
