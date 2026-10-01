using System;

namespace Questao7
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public double Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            return Saldo;
        }

        public double Sacar(double valor)
        {
            Console.WriteLine($"Tentativa de saque de R${valor}");

            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }

            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R${Saldo}");
        }
    }
}