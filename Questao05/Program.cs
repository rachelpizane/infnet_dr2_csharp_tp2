using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Questao05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a temperatura em graus Celsius: ");
            string sTempCelsius = Console.ReadLine();

            if (!ValidarDecimalReal(sTempCelsius))
            {
                Console.WriteLine("Temperatura inválida");
                return;
            }

            double tempCelsius = ConverterStringParaDouble(sTempCelsius);
            double tempFahrenheit = ConverterCelsiusParaFahrenheit(tempCelsius);
            double tempKelvin = ConverterCelsiusParaKelvin(tempCelsius);

            Console.WriteLine("== CONVERSOR DE TEMPERATURA ========");
            Console.WriteLine($"Celsius: {tempCelsius:F2} \nFahrenheit: {tempFahrenheit:F2} \nKelvin: {tempKelvin:F2}");
            Console.WriteLine("====================================");

        }
        static double ConverterCelsiusParaFahrenheit(double tempCelsius)
        {
            return tempCelsius * 9 / 5 + 32;
        }

        static double ConverterCelsiusParaKelvin(double tempCelsius)
        {
            return tempCelsius + 273.15;
        }

        static bool ValidarDecimalReal(string numero)
        {
            return Regex.IsMatch(numero, @"^-?\d+(.\d+)?$");
        }

        static double ConverterStringParaDouble(string numero)
        {
            if (numero.Contains(".")){
                return double.Parse(numero,CultureInfo.InvariantCulture);
            }  
            
            return double.Parse(numero);
        }
    }
}
