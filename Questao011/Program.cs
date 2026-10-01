using System;
using System.IO;

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
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        ListarContatos();
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

        public static void ListarContatos()
        {
            if (!File.Exists("contatos.txt") || new FileInfo("contatos.txt").Length == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            try
            {
                using (StreamReader leitor = new StreamReader("contatos.txt"))
                {
                    string linha;

                    Console.WriteLine("\nContatos cadastrados:");

                    while ((linha = leitor.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');

                        if (dados.Length == 3)
                        {
                            Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao ler contatos.");
            }
        }
    }
}