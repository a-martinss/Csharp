using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pares_e_ímpares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Para verificar se é par ou ímpar, basta análisar se é divisível por 2
             Se for divisível por 2 ==> é par
             Se não for divisível por 2 ==> é ímpar*/
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            //Declaro da Variável
            int numero;
            numero = Convert.ToInt32(txt_Valor.Text);

            if (numero % 2 == 0)
            {
                MessageBox.Show(" O número é par " + numero);
             
            }

            else 
            {
                MessageBox.Show(" O número é ímpar " + numero);
            }
        }
    }
}
