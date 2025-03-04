using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = ObterData("Informe a primeira data (dd/mm/yyyy): ");
            DateTime data2 = ObterData("Informe a segunda data (dd/mm/yyyy): ");

            int anos;
            int meses;
            int dias;

            if(data2 >= data1)
            {
                anos = CalcularAnos(data1, data2);
                meses = CalcularMeses(data1, data2);
                dias = CalcularDias(data1, data2);
            }
            else
            {
                anos = CalcularAnos(data2, data1);
                meses = CalcularMeses(data2, data1);
                dias = CalcularDias(data2, data1);
            }

            Console.WriteLine("== DIFERENÇA ENTRE AS DATAS =========================");
            Console.WriteLine($"Anos: {anos}");
            Console.WriteLine($"Meses: {meses}");
            Console.WriteLine($"Dias: {dias}");
        }

        static DateTime ObterData(string mensagemInput)
        {
            Console.Write(mensagemInput);
            string sData = Console.ReadLine();
            DateTime data;

            while(!DateTime.TryParse(sData, out data))
            {
                Console.WriteLine("Data inválida. Tentar novamente.");

                Console.Write(mensagemInput);
                sData = Console.ReadLine();
            }

            return data;
        }

        static int CalcularAnos(DateTime data1, DateTime data2)
        {
            int anos = data2.Year - data1.Year;

            if (data2.Month < data1.Month || (data2.Month == data1.Month && data2.Day < data1.Day))
            {
                anos--;
            }

            return anos;
        }

        static int CalcularMeses(DateTime data1, DateTime data2)
        {
            int meses = (data2.Year - data1.Year) * 12 + data2.Month - data1.Month;

            if (data2.Day < data1.Day)
            {
                meses--;
            }

            return meses;
        }

        static int CalcularDias(DateTime data1, DateTime data2)
        {
            TimeSpan diferencaDias = data2 - data1;

            return diferencaDias.Days;
        }
    }
}
