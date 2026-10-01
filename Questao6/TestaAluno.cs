using System;

namespace Questao6
{
    public class TestaAluno
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno("João Paulo", "3981826319836", "Engenharia de Software", 10.0);

            aluno.ExibirDados();
            Console.WriteLine(aluno.VerificarAprovacao(aluno.MediaNotas));
        }
    }
}