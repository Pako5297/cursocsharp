using CursoCSProjeto2.Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSProjeto2.Entidades
{
    class Servico
    {
        public DateTime Momento { get; set; }
        public StatusServico Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ListaProduto> Items { get; set; } = new List<ListaProduto>();

        public Servico()
        {
        }

        public Servico(DateTime momento, StatusServico status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ListaProduto item)
        {
            Items.Add(item);
        }
        public void RemoverItem(ListaProduto item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach(ListaProduto p in Items)
            {
                total += p.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append("Momento do serviço: ");
            texto.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            texto.Append("Status do serviço: " + Status);
            texto.AppendLine("Cliente: " + Cliente);
            texto.AppendLine("Itens por ordem de compra:");
            foreach(ListaProduto l in Items)
            {
                texto.AppendLine(l.ToString());
            }
            return texto.ToString();
        }
    }
}
