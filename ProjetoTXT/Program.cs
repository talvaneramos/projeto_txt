using ProjetoTXT.Entities;
using ProjetoTXT.Repositories;
using System;

namespace ProjetoTXT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();
            var produtoRepository = new ProdutoRepository();
            try
            {
                Console.WriteLine("\nCADASTRO DE PRODUTOS\n");

                Console.Write("Informe o código do produto.........: ");
                produto.Codigo = int.Parse(Console.ReadLine());

                Console.Write("Informe o nome do produto...........: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Informe o preço do produto..........: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Informe a quantidade do produto.....: ");
                produto.Quantidade = int.Parse(Console.ReadLine());


                Console.WriteLine("\nREGISTRO DO PRODUTO:\n");

                Console.WriteLine("Código..........................: " + produto.Codigo);
                Console.WriteLine("Nome............................: " + produto.Nome);
                Console.WriteLine("Preço...........................: " + produto.Preco);
                Console.WriteLine("Quantidade......................: " + produto.Quantidade);                

                produtoRepository.GravarArquivo(produto);
                Console.WriteLine("\nProduto gravado com sucesso!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nOcorreu um erro: " + ex);
            }
            Console.ReadKey();
        }
    }
}
