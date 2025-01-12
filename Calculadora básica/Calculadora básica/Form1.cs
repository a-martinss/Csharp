using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_básica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            //Declaro da Variável Soma
            Double v1, v2, soma;
            v1 = Double.Parse(txt_Num1.Text);
            v2 = Double.Parse(txt_Num2.Text);

            //Somando os valores
            soma = v1 + v2;
            txt_Resultado.Text = soma.ToString();
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            //Declaro da Variável Subtração
            Double v1, v2, Subtração;
            v1 = Double.Parse(txt_Num1.Text);
            v2 = Double.Parse(txt_Num2.Text);

            //Subtraindo os valores
            Subtração = v1 - v2;
            txt_Resultado.Text = Subtração.ToString();
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            //Declaro da Variável Multiplicação
            Double v1, v2, Multiplicação;
            v1 = Double.Parse(txt_Num1.Text);
            v2 = Double.Parse(txt_Num2.Text);

            //Multiplicando os valores
            Multiplicação = v1 * v2;
            txt_Resultado.Text = Multiplicação.ToString();
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            //Declaro da Variável Divisão
            Double v1, v2, Divisão;
            v1 = Double.Parse(txt_Num1.Text);
            v2 = Double.Parse(txt_Num2.Text);

            //Dividindo os valores
            Divisão = v1 / v2;
            txt_Resultado.Text = Divisão.ToString();
        }

        private void bloqueada_TextChanged(object sender, EventArgs e)
        {
            //Bloqueando a Instância do Botão
            bloqueada.ReadOnly = true;
        }
    }
}
