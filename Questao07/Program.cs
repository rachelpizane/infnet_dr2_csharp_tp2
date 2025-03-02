using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            string sNumero = Console.ReadLine();

            if (!ValidarInteiro(sNumero))
            {
                Console.WriteLine("Número inválido");
                return;
            }

            int numero = ConverterStringParaInt(sNumero);
            string resposta = "ímpar";

            if (numero % 2 == 0)
            {
                resposta = "par";
            }

            Console.WriteLine("== PAR OU IMPAR? =============");
            Console.WriteLine($"O número {numero} é {resposta}.");
        }

        static bool ValidarInteiro(string numero)
        {
            return Regex.IsMatch(numero, @"^\d+$");
        }

        static int ConverterStringParaInt(string numero)
        {
            return int.Parse(numero);
        }
    }
}
