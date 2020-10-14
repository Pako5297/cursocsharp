using CursoCSProjeto2.Entidades;
using CursoCSProjeto2.Entidades.Enumerados;
using System;

namespace CursoCSProjeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nasc. (DD/MM/AAAA): ");
            DateTime anoNasc = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, anoNasc);
            Console.WriteLine("Entre com status do serviço:");
            Console.Write("Status: ");
            StatusServico status = Enum.Parse<StatusServico>(Console.ReadLine());
            Servico servico = new Servico(DateTime.Now, status, cliente);
            Console.Write("Quantos itens terá o pedido? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Entre com os dados do item #"+i);
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto, precoProduto);
                Console.Write("Quantidade: ");
                int qdtProduto = int.Parse(Console.ReadLine());
                ListaProduto lista = new ListaProduto(qdtProduto, precoProduto, produto);
                servico.AddItem(lista);
            }
            Console.WriteLine();
            Console.WriteLine("Resumo dos serviços:");
            Console.WriteLine(servico);
        }
    }
}
