using System;

namespace Questao13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            string numero2 = Console.ReadLine();

            Console.WriteLine("Digite a operação que deseja: soma(1), subtração(2), multiplicação(3) e divisão(4):");
            string operacao = Console.ReadLine();

            int numero1Convertido;
            int numero2Convertido;
            bool valido1 = int.TryParse(numero1, out numero1Convertido);
            bool valido2 = int.TryParse(numero2, out numero2Convertido);

            if (!valido1 || !valido2)
            {
                Console.WriteLine("Digite um número válido!");
            }
            else if (numero2Convertido == 0 && operacao == "4")
            {
                Console.WriteLine("Não é permitido divisão por zero!");
            }
            else
            {
                switch (operacao)
                {
                    case "1":
                        Console.WriteLine($"Resultado: {numero1Convertido + numero2Convertido}");
                        break;
                    case "2":
                        Console.WriteLine($"Resultado: {numero1Convertido - numero2Convertido}");
                        break;
                    case "3":
                        Console.WriteLine($"Resultado: {numero1Convertido * numero2Convertido}");
                        break;
                    case "4":
                        Console.WriteLine($"Resultado: {numero1Convertido / numero2Convertido}");
                        break;
                    default:
                        Console.WriteLine("Digite o número de uma operação válida!");
                        break;
                }
            }
        }
    }
}