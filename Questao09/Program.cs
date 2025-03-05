using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao09
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Digite o salário bruto: ");
            string sSalarioBruto = Console.ReadLine();

            if (!ValidarDecimal(sSalarioBruto))
            {
                Console.WriteLine("Salário bruto inválido");
                return;
            }

            double salarioBruto = ConverterStringParaDouble(sSalarioBruto);
            double descontoImposto = CalcularImposto(salarioBruto);

            double salarioLiquido = salarioBruto - descontoImposto;

            Console.WriteLine("== CALCULADORA DE SALARIO LIQUIDO ==============");
            Console.WriteLine($"\nSalário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto de Imposto: R$ {descontoImposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }

        static bool ValidarDecimal(string numero)
        {
            return Regex.IsMatch(numero, @"^\d+(.\d+)?$") && ConverterStringParaDouble(numero) > 0;
        }

        static double ConverterStringParaDouble(string numero)
        {
            if (numero.Contains("."))
            {
                return double.Parse(numero, CultureInfo.InvariantCulture);
            }

            return double.Parse(numero);
        }

        static double CalcularImposto(double salario)
        {
            const double FAIXA_1 = 2259.20;
            const double FAIXA_2 = 2826.65;
            const double FAIXA_3 = 3751.05;
            const double FAIXA_4 = 4664.68;

            const double ALIQUOTA_1 = 0.075;  
            const double ALIQUOTA_2 = 0.15;   
            const double ALIQUOTA_3 = 0.225;  
            const double ALIQUOTA_4 = 0.275; 

            double imposto = 0;

            if (salario <= FAIXA_1)
            {
                imposto = 0;
            }
            else if (salario <= FAIXA_2)
            {
                imposto = (salario - FAIXA_1) * ALIQUOTA_1;
            }
            else if (salario <= FAIXA_3)
            {
                imposto = (salario - FAIXA_2) * ALIQUOTA_2 + (FAIXA_2 - FAIXA_1) * ALIQUOTA_1;
            }
            else if (salario <= FAIXA_4)
            {
                imposto = (salario - FAIXA_3) * ALIQUOTA_3 + (FAIXA_3 - FAIXA_2) * ALIQUOTA_2 + (FAIXA_2 - FAIXA_1) * ALIQUOTA_1;
            }
            else
            {
                imposto = (salario - FAIXA_4) * ALIQUOTA_4 + (FAIXA_4 - FAIXA_3) * ALIQUOTA_3 + (FAIXA_3 - FAIXA_2) * ALIQUOTA_2 + (FAIXA_2 - FAIXA_1) * ALIQUOTA_1;
            }

            return imposto;
        }
    }
}
