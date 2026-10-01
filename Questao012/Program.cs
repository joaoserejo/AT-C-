using System;
using System.IO;
using System.Collections.Generic;

namespace GerenciadorContatos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string opcao = "";

            while (opcao != "3")
            {
                Console.WriteLine("\n=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Exibir contatos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        List<Contato> contatos = LerContatos();

                        if (contatos.Count == 0)
                        {
                            Console.WriteLine("Nenhum contato cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("Escolha o formato de exibição:");
                            Console.WriteLine("1 - Markdown");
                            Console.WriteLine("2 - Tabela");
                            Console.WriteLine("3 - Texto Puro");
                            Console.Write("Opção: ");

                            string formato = Console.ReadLine();
                            ContatoFormatter formatter;

                            switch (formato)
                            {
                                case "1":
                                    formatter = new MarkdownFormatter();
                                    break;
                                case "2":
                                    formatter = new TabelaFormatter();
                                    break;
                                default:
                                    formatter = new RawTextFormatter();
                                    break;
                            }

                            formatter.ExibirContatos(contatos);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public static void AdicionarContato()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            try
            {
                using (StreamWriter escritor = new StreamWriter("contatos.txt", true))
                {
                    escritor.WriteLine($"{nome},{telefone},{email}");
                }

                Console.WriteLine("Contato cadastrado com sucesso!");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao salvar contato.");
            }
        }

        public static List<Contato> LerContatos()
        {
            List<Contato> contatos = new List<Contato>();

            try
            {
                if (File.Exists("contatos.txt"))
                {
                    using (StreamReader leitor = new StreamReader("contatos.txt"))
                    {
                        string linha;

                        while ((linha = leitor.ReadLine()) != null)
                        {
                            string[] dados = linha.Split(',');

                            if (dados.Length == 3)
                            {
                                contatos.Add(new Contato(dados[0], dados[1], dados[2]));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao ler contatos.");
            }

            return contatos;
        }
    }
}