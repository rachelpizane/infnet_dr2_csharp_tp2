using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu peso (kg): ");
            string sPeso = Console.ReadLine();

            if (!ValidarDecimal(sPeso))
            {
                Console.WriteLine("Peso inválido");
                return;
            }

            Console.Write("Informe a sua altura (m): ");
            string sAltura = Console.ReadLine();

            if (!ValidarDecimal(sAltura))
            {
                Console.WriteLine("Altura inválida");
                return;
            }

            double peso = ConverterStringParaDouble(sPeso);
            double altura = ConverterStringParaDouble(sAltura);

            double imc = peso / (altura * altura);
            string classificacao = "";

            if(imc < 18.5)
            {
                classificacao = "Magreza";
            } 
            else if (imc <= 24.9)
            {
                classificacao = "Normal";
            } 
            else if (imc <= 29.9) 
            {
                classificacao = "Sobrepeso";
            } 
            else if (imc <= 39.9)
            {
                classificacao = "Obesidade";
            } 
            else if (imc >= 40)
            {
                classificacao = "Obesidade Grave";
            }


            Console.WriteLine("== CALCULO DE IMC ==================");
            Console.WriteLine($"IMC: {imc:F2} \nClassificação: {classificacao}");

        }

        static bool ValidarDecimal(string numero)
        {
            return Regex.IsMatch(numero, @"^?\d+(.\d+)?$") && ConverterStringParaDouble(numero) > 0;
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
