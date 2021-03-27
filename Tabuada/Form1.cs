using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNumero.Text = "";
           
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, numero, resultado;
            i = 1;
            numero = int.Parse(textNumero.Text);
            
            while(i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, " X ", i, " = ", resultado));
                i++;
            }

        }
    }
}
