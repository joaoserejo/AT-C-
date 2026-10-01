using System;

namespace Questao2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            
            string novoNome = CifrarTexto(nome);

           
            Console.WriteLine($"Nome cifrado: {novoNome}");
        }

        
        public static string CifrarTexto(string texto)
        {
            char[] letras = texto.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] >= 'a' && texto[i] <= 'z')
                {
                    letras[i] = (char)(((texto[i] - 'a') + 2) % 26 + 'a');
                }
                else if (texto[i] >= 'A' && texto[i] <= 'Z')
                {
                    letras[i] = (char)(((texto[i] - 'A') + 2) % 26 + 'A');
                }
            }

            return new string(letras);
        }
    }
}