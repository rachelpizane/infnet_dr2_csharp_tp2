using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro não-negativo: ");
            String sNumero = Console.ReadLine();

            if (!ValidarInteiro(sNumero))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            int numero = ConverterStringParaInt(sNumero);

            List<int> numeros = new List<int>();

            while (numero >= 0)
            {
                numeros.Add(numero);
                numero--;
            }

            Console.WriteLine("== CONTAGEM REFRESSIVA =========");
            Console.WriteLine(">> " + string.Join(", ", numeros));

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

