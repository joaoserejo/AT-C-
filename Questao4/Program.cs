using System;

namespace Questao4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa): ");
            string data = Console.ReadLine();

            DateTime dataConvertida;
            bool dataValida = DateTime.TryParse(data, out dataConvertida);

            if (!dataValida)
            {
                Console.WriteLine("Data inválida. Digite corretamente no formato dd/mm/aaaa.");
                return;
            }

            DateTime hoje = DateTime.Today;

            int ano = hoje.Year;
            int mes = dataConvertida.Month;
            int dia = dataConvertida.Day;

            DateTime proximoAniversario = new DateTime(ano, mes, dia);

            if (hoje > proximoAniversario)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            TimeSpan diferenca = proximoAniversario - hoje;

            if (diferenca.TotalDays < 7)
            {
                Console.WriteLine("Seu aniversário está muito próximo, parabéns!");
            }
            else
            {
                int diasRestantes = (int)diferenca.TotalDays;
                Console.WriteLine($"Dias restantes: {diasRestantes}");
            }
        }
    }
}