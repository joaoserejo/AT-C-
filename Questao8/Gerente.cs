using System;

namespace Questao8
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salarioBase) : base(nome, cargo, salarioBase)
        {
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() * 1.20;
        }
    }
}