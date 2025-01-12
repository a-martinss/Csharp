using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Você foi contratado para desenvolver um programa simples para uma escola que permite aos professores
            inserirem as notas de um aluno e determinar se ele foi aprovado ou reprovado com base nessas notas.*/

            //Declaro das Variáveis
            double nota1, nota2;
            double media = 0;

            //Exibindo os valores
            Console.WriteLine("Verificar se o Aluno foi Aprovado, está em recuperação ou se foi Reprovado.");

            Console.WriteLine("Informe a primeira nota (de 0 a 10):");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota (de 0 a 10):");
            nota2 = double.Parse(Console.ReadLine());

            //Fazendo o Cálculo da Conversão
            media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine("Aluno Aprovado!" + media);
            }

            else if (media < 6 && media >= 6)
            {
                Console.WriteLine("Aluno em recuperação!" + media);
            }

            else
            {
                Console.WriteLine("Aluno reprovado!" + media);
            }
        }
    }
}
