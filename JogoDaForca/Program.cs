using System;
using System.Collections.Generic;

namespace JogoDaForca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palavras = new List<string>();
            string palavra;
            string palavraAleatorio;
            Console.WriteLine("Adicione uma lista de palavras! (Digite 'sair' para encerrar)");

            do
            {
                Console.Write("Digite uma palavra: ");
                palavra = Console.ReadLine();

                if (palavra.ToLower() != "sair")
                {
                    palavras.Add(palavra);
                }

            } while (palavra.ToLower() != "sair");

            Random random = new Random();
            int erros = 0;
            bool acertou = false;

            Console.WriteLine("Coloque um caracter: ");

            foreach (string palavraAtual in palavras)
            {
                int indexAleatorio = random.Next(0, palavraAtual.Length);
                palavraAleatorio = palavraAtual;

                for (int i = 0; i < palavraAleatorio.Length; i++)
                {
                    char Letra = char.Parse(Console.ReadLine());

                    if (i < palavraAleatorio.Length && Letra == palavraAleatorio[i])
                    {
                        Console.WriteLine(Letra);
                    }
                    else
                    {
                        erros++;
                        Console.WriteLine(new string('I', erros));
                    }
                }

                if (erros == 0)
                {
                    Console.WriteLine("Parabéns! Você acertou a palavra: " + palavraAleatorio);
                    acertou = true;
                    break; // Se acertou, não precisa continuar para as próximas palavras
                }
                else
                {
                    erros = 0; // Reseta o contador de erros para a próxima palavra
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Você não acertou nenhuma palavra.");
            }
        }
    }
}
