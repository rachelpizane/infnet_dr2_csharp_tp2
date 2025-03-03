using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua nota (0 a 10): ");
            string sNota = Console.ReadLine();

            if (!ValidarDecimal(sNota))
            {
                Console.WriteLine("Nota inválida");
                return;
            }

            double nota = ConverterStringParaDouble(sNota);

            string classificacao = "";

            if (nota < 2.5)
            {
                classificacao = "Insuficiente";
            }
            else if (nota <= 5)
            {
                classificacao = "Regular";
            }
            else if (nota <= 7.5)
            {
                classificacao = "Bom";
            }
            else if (nota <= 10)
            {
                classificacao = "Excelente";
            }
    

            Console.WriteLine("== CLASSIFICAÇÃO DA NOTA ESCOLAR ==============");
            Console.WriteLine($"Nota: {nota:F2} \nClassificação: {classificacao}");

        }

        static bool ValidarDecimal(string numero)
        {
            return Regex.IsMatch(numero, @"^\d+(.\d+)?$") && ConverterStringParaDouble(numero) <= 10;
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
