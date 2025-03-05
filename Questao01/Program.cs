using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNascimento = ObterData("Informe sua data de nascimento (dd/mm/yyyy): ");
            DateTime dataAtual = DateTime.Today;

            int anos = CalcularAnos(dataNascimento, dataAtual);
            int meses = CalcularMeses(dataNascimento, dataAtual);
            int dias = CalcularDias(dataNascimento, dataAtual);

            Console.WriteLine("== SUA IDADE EXATA ===============================");
            Console.WriteLine($"Você tem {anos} ano(s), {meses} mes(es) e {dias} dia(s) de idade.");
        }

        static DateTime ObterData(string mensagemInput)
        {
            Console.Write(mensagemInput);
            string sData = Console.ReadLine();
            DateTime data;


            while (!DateTime.TryParse(sData, out data) || data > DateTime.Today)
            {
                Console.WriteLine("Data inválida. Tentar novamente.");

                Console.Write(mensagemInput);
                sData = Console.ReadLine();
            }

            return data;
        }

        static int CalcularAnos(DateTime dataNascimento, DateTime dataAtual)
        {
            int anos = dataAtual.Year - dataNascimento.Year;

            if (dataAtual.Month < dataNascimento.Month || (dataAtual.Month == dataNascimento.Month && dataAtual.Day < dataNascimento.Day))
            {
                anos--;
            }

            return anos;
        }

        static int CalcularMeses(DateTime dataNascimento, DateTime dataAtual)
        {
            int meses = dataAtual.Month - dataNascimento.Month;

            if (meses < 0)
            {
                meses += 12;
            }

            if (dataAtual.Day < dataNascimento.Day) 
            {
                meses--;
            }

            return meses;
        }

        static int CalcularDias(DateTime dataNascimento, DateTime dataAtual)
        {
            int dias = dataAtual.Day - dataNascimento.Day;

            if (dias < 0)
            {
                DateTime ultimoMes = dataAtual.AddMonths(-1);
                dias += DateTime.DaysInMonth(ultimoMes.Year, ultimoMes.Month);
            }

            return dias;
        }
    }
}
