using System;
using System.Globalization;

namespace QuestaoFormatura
{
    public class Program
    {
        public static void Main()
        {
            DateTime dataFormatura = new DateTime(2026, 12, 15);

            Console.Write("Digite a data atual (dd/MM/yyyy): ");

            if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataAtual))
            {
                Console.WriteLine("Erro: Formato de data inválido.");
                return;
            }

            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = dataFormatura.Year - dataAtual.Year;
            int meses = dataFormatura.Month - dataAtual.Month;
            int dias = dataFormatura.Day - dataAtual.Day;

            if (dias < 0)
            {
                meses--;

                DateTime mesAtual = dataAtual.AddYears(anos).AddMonths(meses);
                DateTime proximoMes = dataAtual.AddYears(anos).AddMonths(meses + 1);

                dias += (proximoMes - mesAtual).Days;
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");

            if ((anos * 12) + meses < 6)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
    }
}