using System;
using System.Collections.Generic;

namespace GerenciadorContatos
{
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
            }
        }
    }
}