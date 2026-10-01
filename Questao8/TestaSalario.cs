using System;

namespace Questao8
{
    public class TestaSalario
    {
        public static void Main(string[] args)
        {
            Gerente meuGerente = new Gerente("Ana", "Gerente de Projetos", 5000);
            Funcionario meuFuncionario = new Funcionario("Carlos", "Desenvolvedor", 5000);

            Console.WriteLine($"Salário final do funcionário: {meuFuncionario.CalcularSalario()}");
            Console.WriteLine($"Salário final do gerente: {meuGerente.CalcularSalario()}");
        }
    }
}