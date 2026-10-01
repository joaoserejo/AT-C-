using System;

namespace Questao7
{
    public class TestaConta
    {
        public static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria("João Silva", 0);

            Console.WriteLine($"Titular: {contaBancaria.Titular}");

            contaBancaria.Depositar(500);
            contaBancaria.ExibirSaldo();

            contaBancaria.Sacar(700);
            contaBancaria.Sacar(200);

            contaBancaria.ExibirSaldo();
        }
    }
}