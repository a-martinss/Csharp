﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa de verificação de idade que solicita ao usuário inserir sua idade.
            Se a idade inserida for maior ou igual a 18, exiba uma mensagem dizendo que a pessoa é maior de idade.
            Caso contrário, exiba uma mensagem informando que é menor de idade.*/

            // Solicitar ao usuário que digite a idade
            Console.Write("Digite a idade da pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Verificar se a pessoa é maior ou menor de idade
            if (idade >= 18)
            {
                Console.WriteLine("Esta pessoa é maior de idade.");
            }
            else
            {
                Console.WriteLine("Esta pessoa é menor de idade.");
            }
        }
    }
}
