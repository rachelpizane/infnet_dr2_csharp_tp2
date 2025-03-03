using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSorteado = random.Next(1, 101);

            int tentativas = 1;
            bool acertou = false;
            bool tentarNovamente = true;

            do
            {
                Console.Write($"[Tentativa nº {tentativas}] Informe um número inteiro entre 1 e 100: ");
                String sPalpite = Console.ReadLine();

                if (!ValidarInteiroEntre1e100(sPalpite))
                {
                    Console.WriteLine("Número inválido. Tente novamente");
                    continue;
                }

                int palpite = ConverterStringParaInt(sPalpite);

                String resposta = ">> ";

                if (palpite > numeroSorteado)
                {
                    resposta += "O número sorteado é menor.";

                }
                else if (palpite < numeroSorteado)
                {
                    resposta += "O número sorteado é maior.";

                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número sorteado em {tentativas} tentativa(s).");
                    acertou = true;
                    tentarNovamente = false;
                }

                if (!acertou)
                {
                    Console.WriteLine(resposta);

                    bool sair = false;
                    do
                    {
                        Console.WriteLine("Deseja tentar novamente? [s/n]");
                        string opcao = Console.ReadLine();

                        switch (opcao.ToLower())
                        {
                            case "s":
                                tentativas++;
                                sair = true;
                                break;

                            case "n":
                                tentarNovamente = false;
                                sair = true;
                                break;

                            default:
                                Console.WriteLine("Opção inválida.Tentar novamente.");
                                sair = false;
                                break;
                        }

                    } while (!sair);      

                }

            } while (!acertou && tentarNovamente);

            Console.WriteLine("Fim de Jogo");
        }

        static bool ValidarInteiroEntre1e100(string numero)
        {
            return Regex.IsMatch(numero, @"^\d+$") && ConverterStringParaInt(numero) >= 1 && ConverterStringParaInt(numero) <= 100;
        }

        static int ConverterStringParaInt(string numero)
        {
            return int.Parse(numero);
        }
    }
}
