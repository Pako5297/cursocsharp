using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSProjeto2.Entidades
{
    class ListaProduto
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ListaProduto()
        {
        }

        public ListaProduto(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", R$"
                + Preco
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: R$"
                + SubTotal();
        }
    }
}
