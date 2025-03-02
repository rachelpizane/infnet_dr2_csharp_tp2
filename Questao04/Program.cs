using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine();

            if (!validarEntradaVazia(nome))
            {
                Console.WriteLine("Nome inválido.");
                return;
            }

            Console.Write("Informe a sua idade: ");
            string idade = Console.ReadLine();

            if (!validarIdade(idade)){
                Console.WriteLine("Idade inválida");
                return;
            }

            Console.Write("Informe o seu telefone (min: 8 | máx: 11 números): ");
            string telefone = Console.ReadLine();

            if (!validarTelefone(telefone))
            {
                Console.WriteLine("Telefone inválido");
                return;
            }

            Console.Write("Informe o seu e-mail: ");
            string email = Console.ReadLine();

            if (!validarEmail(email))
            {
                Console.WriteLine("Email inválido");
                return;
            }

            Console.WriteLine("== INFO =================");
            Console.WriteLine($"Nome: {nome} \nIdade: {idade} \nTelefone: {telefone} \nE-mail: {email}");
            Console.WriteLine("=========================");
        }

        static bool validarEntradaVazia(string entrada)
        {
            return !string.IsNullOrWhiteSpace(entrada);
        }

        static bool validarIdade(string idade)
        {
            return Regex.IsMatch(idade, @"^\d+$") && converterStringParaInt(idade) > 0;
        }

        static bool validarTelefone(string telefone)
        {
            return Regex.IsMatch(telefone, @"^\d{8,11}$");
        }

        static bool validarEmail(string email)
        {
            return Regex.IsMatch(email, @"@{1}");
        }

        static int converterStringParaInt(string numero)
        {
            return int.Parse(numero);
        }
    }
}
