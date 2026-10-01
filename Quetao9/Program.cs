using System;
using System.IO;

namespace Questao09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nomes = new string[5];
            int[] quantidade = new int[5];
            double[] preco = new double[5];
            int quantidadeProdutos = 0;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("1. Inserir Produtos\n2. Listar Produtos\n3. Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (quantidadeProdutos == 5)
                        {
                            Console.WriteLine("Limite de produtos atingido!");
                        }
                        else
                        {
                            Console.WriteLine("Digite o nome do produto:");
                            string nomeProduto = Console.ReadLine();

                            Console.WriteLine("Digite a quantidade do produto:");
                            int quantidadeProdutosEscolhidos = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o preço do produto:");
                            double precoProduto = double.Parse(Console.ReadLine());

                            nomes[quantidadeProdutos] = nomeProduto;
                            quantidade[quantidadeProdutos] = quantidadeProdutosEscolhidos;
                            preco[quantidadeProdutos] = precoProduto;
                            quantidadeProdutos++;

                            using (StreamWriter escritor = File.AppendText("estoque.txt"))
                            {
                                escritor.WriteLine($"{nomeProduto},{quantidadeProdutosEscolhidos},{precoProduto}");
                            }

                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                        break;

                    case "2":
                        if (!File.Exists("estoque.txt") || new FileInfo("estoque.txt").Length == 0)
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                        else
                        {
                            try
                            {
                                using (StreamReader leitor = new StreamReader("estoque.txt"))
                                {
                                    string linha;

                                    while ((linha = leitor.ReadLine()) != null)
                                    {
                                        string[] dados = linha.Split(',');

                                        if (dados.Length == 3)
                                        {
                                            Console.WriteLine($"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: R$ {double.Parse(dados[2]):F2}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Registro inválido encontrado no arquivo.");
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Erro ao ler o arquivo.");
                            }
                        }
                        break;

                    case "3":
                        continuar = false;
                        Console.WriteLine("Encerrando programa...");
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }
    }
}