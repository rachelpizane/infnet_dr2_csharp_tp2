using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            String sNumero = Console.ReadLine();

            if (!ValidarDecimalReal(sNumero))
            {
                Console.WriteLine("Número inválido");
                return;
            }

            double numero = ConverterStringParaDouble(sNumero);

            Console.WriteLine("== TABUADA =========================");
            for(int i = 1; i <= 10; i++)
            {
                double multiplicacao = numero * i;
                Console.WriteLine($"{numero} x {i} = {multiplicacao}");
            }
        }

        static bool ValidarDecimalReal(string numero)
        {
            return Regex.IsMatch(numero, @"^-?\d+(.\d+)?$");
        }

        static double ConverterStringParaDouble(string numero)
        {
            if (numero.Contains("."))
            {
                return double.Parse(numero, CultureInfo.InvariantCulture);
            }

            return double.Parse(numero);
        }
    }
}
