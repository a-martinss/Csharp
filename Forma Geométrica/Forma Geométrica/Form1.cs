using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Geométrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rb_Circulo.Checked)
            {
                double diametro;
                if (double.TryParse(txt_Diâmetro.Text, out diametro))
                {
                    double area = Math.PI * Math.Pow(diametro / 2, 2);
                    txt_Resultado.Text = $"A área do círculo é: {area}";
                }
                else
                {
                    MessageBox.Show("Insira um valor para o diâmetro do círculo.");
                }
            }

            else if (rb_Triângulo.Checked)
            {
                double lado1, lado2, lado3;
                if (double.TryParse(txt_Valor1.Text, out lado1) &&
                    double.TryParse(txt_Valor2.Text, out lado2) &&
                    double.TryParse(txt_Valor3.Text, out lado3))
                {
                    double perimetro = lado1 + lado2 + lado3;
                    double semiPerimetro = perimetro / 2;
                    double area = Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3));
                    txt_Resultado.Text = $"O perímetro do triângulo é: {perimetro}\nA área do triângulo é: {area}";
                }
                else
                {
                    MessageBox.Show("Insira os valores, para os lados do triângulo.");
                }
            }

            else if (rb_Quadrilátero.Checked)
            {
                double lado1, lado2, lado3, lado4;
                if (double.TryParse(txt_Valor1.Text, out lado1) &&
                    double.TryParse(txt_Valor2.Text, out lado2) &&
                    double.TryParse(txt_Valor3.Text, out lado3) &&
                    double.TryParse(txt_Valor4.Text, out lado4))
                {
                    double perimetro = lado1 + lado2 + lado3 + lado4;
                    double area = Math.Sqrt((perimetro / 2 - lado1) * (perimetro / 2 - lado2) * (perimetro / 2 - lado3) * (perimetro / 2 - lado4));
                    txt_Resultado.Text = $"O perímetro do quadrilátero é: {perimetro}\nA área do quadrilátero é: {area}";
                }
                else
                {
                    MessageBox.Show("Insira os valores para os lados do quadrilátero.");
                }
            }

            else
            {
                MessageBox.Show("Selecione uma forma geométrica!.");
            }
        }

        private void rb_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Diâmetro.Visible = true;
            txt_Valor1.Visible = false;
            txt_Valor2.Visible = false;
            txt_Valor3.Visible = false;
            txt_Valor4.Visible = false;
        }

        private void rb_Triângulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Diâmetro.Visible = false;
            txt_Valor1.Visible = true;
            txt_Valor2.Visible = true;
            txt_Valor3.Visible = true;
            txt_Valor4.Visible = false;
        }

        private void rb_Quadrilátero_CheckedChanged(object sender, EventArgs e)
        {
            txt_Diâmetro.Visible = false;
            txt_Valor1.Visible = true;
            txt_Valor2.Visible = true;
            txt_Valor3.Visible = true;
            txt_Valor4.Visible = true;
        }
    }
}
