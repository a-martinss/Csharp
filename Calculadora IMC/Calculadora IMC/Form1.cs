using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //Declaro das Variáveis
            double Altura, Peso;

            Altura = Convert.ToDouble(txt_Altura.Text);
            Peso = Convert.ToDouble(txt_Peso.Text);

            //Fazendo o Cálculo da Conversão
            double IMC = Peso / (Altura * Altura);

            //Homem
            if (rb_Homem.Checked = IMC < 16.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Muito abaixo do peso!";
            }

            else if (IMC >= 17 && IMC <= 18.4)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Abaixo do peso!";
            }

            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Peso Normal!";
            }

            else if (IMC >= 25 && IMC <= 29.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Sobrepeso!";
            }

            else if (IMC >= 30 && IMC <= 34.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Obesidade 1º Grau!";
            }

            else if (IMC >= 35 && IMC <= 39.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Obesidade 2º Grau!";
            }

            else
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Obesidade 3º Grau!";
            }


            //Mulher
            if (rb_Mulher.Checked = IMC < 15.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Muito abaixo do peso!";
            }

            else if (IMC >= 16 && IMC <= 17.4)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Abaixo do peso!";
            }

            else if (IMC >= 17.5 && IMC <= 23.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Peso Normal!";
            }

            else if (IMC >= 24 && IMC <= 28.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Sobrepeso!";
            }

            else if (IMC >= 29 && IMC <= 33.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Obesidade 1º Grau!";
            }

            else if (IMC >= 34 && IMC <= 38.9)
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Obesidade 2º Grau!";
            }

            else
            {
                txt_IMC.Text = IMC.ToString("F2");
                txt_Resultado.Text = "Obesidade 3º Grau!";
            }
        }
    }
}
