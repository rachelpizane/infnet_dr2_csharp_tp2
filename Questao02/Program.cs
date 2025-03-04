using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe sua data de nascimento (dd/mm/yyyy): ");
            string sDataNascimento = Console.ReadLine();

            DateTime dataNascimento;

            if (!DateTime.TryParse(sDataNascimento, out dataNascimento) || dataNascimento > DateTime.Today)
            {
                Console.Write("Data inválida.");
                return;
            }

            int diasParaProximoAniversario = CalcularDiasParaProximoAniversario(dataNascimento);

            Console.WriteLine("== QUANTOS DIAS FALTAM PARA O SEU ANIVERSARIO? =========================");
            Console.WriteLine($"Faltam {diasParaProximoAniversario} dia(s) para o seu próximo aniversário.");
        }

        static int CalcularDiasParaProximoAniversario(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
                Console.WriteLine(proximoAniversario);
            }

            int dias = (proximoAniversario - hoje).Days;
        
            return dias;
        }
    }
}
