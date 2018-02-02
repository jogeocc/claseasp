using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDos
{
    public partial class ProyectoDos : Form
    {
        Int16 a, b, c;
        Int16 cuanto,contador=0;
        decimal prom,promgen;
        decimal[] promprom = new decimal[10];

        public ProyectoDos()
        {
            InitializeComponent();
            txtCuantos.Enabled = true;
        }



        private void BotonGenerar(object sender, EventArgs e)
        {
            Libreria.Libreria obj= new Libreria.Libreria();
            // prom = (a + b + c) / 3;
          
            prom = obj.calprom(a, b, c);
            promprom[contador] = prom;
            LbProm.Text = ""+prom;
            contador++;

            if (contador == cuanto) {
                promgen=obj.CalPromProms(promprom, cuanto);
                lblPromGen.Text ="El promedio es :"+ Convert.ToString(promgen);
                lblMensaje.Text = Convert.ToString("Ya son N veces...");
                TxbA.Enabled= false;
                TxbB.Enabled = false;
                TxbC.Enabled = false;

            }

            else
            {
                //Limpiar Campos
                TxbA.Text = "";
                TxbB.Text = "";
                TxbC.Text = "";
            }

        }

        private void txtCuantos_TextChanged(object sender, EventArgs e)
        {
            if (txtCuantos.Text != "")
                cuanto = Convert.ToInt16(txtCuantos.Text);
        }

        private void TxbA_TextChanged(object sender, EventArgs e)
        {
            txtCuantos.Enabled = false;
            if(TxbA.Text!="")
                a = Convert.ToInt16(TxbA.Text);    
        }

        private void TxbB_TextChanged(object sender, EventArgs e)
        {
            if (TxbB.Text != "")
                b = Convert.ToInt16(TxbB.Text);
        }

        private void TxbC_TextChanged(object sender, EventArgs e)
        {
            if (TxbC.Text != "")
                c = Convert.ToInt16(TxbC.Text);
        }

       


    }
}
