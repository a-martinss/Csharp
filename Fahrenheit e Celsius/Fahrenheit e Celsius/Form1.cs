using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_e_Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Desenvolva um programa de conversão de temperatura que permita ao usuário escolher entre Celsius e Fahrenheit 
            usando radio buttons.Se o usuário selecionar Celsius, o programa converterá a temperatura inserida em Fahrenheit. 
            Se o usuário selecionar Fahrenheit, o programa converterá a temperatura inserida em Celsius.

            Para converter de Celsius para Fahrenheit:
            5 / 9 * C + 32

            Para converter de Fahrenheit para Celsius:
            9 / 5 * (F−32)*/
        }

        private void btn_ExibirTemperatura_Click(object sender, EventArgs e)
        {
            //Declaro das Variáveis
            double v1, Celsius;
            v1 = Convert.ToInt32(txt_Num.Text);

            Celsius = ((v1 * 9 ) / 5) +32;

            double v2, Fahrenheit;
            v2 = Convert.ToInt32(txt_Num.Text);

             
            Fahrenheit = ((v2 - 32) * 5) / 9;

            if (rb_Celsius.Checked)
            {
                //Mostrando o resultado da Conversão de celsius para Fahrenheit
                lbl_Resultado.Text = Celsius.ToString() + " Fahrenheit ";
            }

            else {
                //Mostrando o resultado da Conversão de Fahrenheit para celsius 
                lbl_Resultado.Text = Fahrenheit.ToString() + " Celsius ";
            }
        }
    }
}
