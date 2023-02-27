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
    public partial class FormMenuInicial : Form
    {
        public FormMenuInicial()
        {
            InitializeComponent();
        }

        private void FormMenuInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIngresarMovimiento_Click(object sender, EventArgs e)
        {
            Form openform = new FormNuevoMovimiento();
            openform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form openform = new FormBalanceSaldos();
            openform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form openform = new FormBalanceGeneral();
            openform.Show();

          
        }
    }
}
