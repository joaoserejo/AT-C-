using System;

namespace Questao10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random sorteio = new Random();
            int numero = sorteio.Next(1, 51);
            int contador = 0;

            Console.WriteLine("Acerte 5 números de 1 a 50");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Tentativa {i + 1}:");

                try
                {
                    int tentativa = int.Parse(Console.ReadLine());

                    if (tentativa < 1 || tentativa > 50)
                    {
                        throw new ArgumentException("Número inválido digitado.");
                    }

                    if (tentativa == numero)
                    {
                        contador++;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Você deve digitar um número válido.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Acertos: {contador}");
        }
    }
}