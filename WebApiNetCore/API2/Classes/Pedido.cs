using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Classes
{
    public class Pedido
    {
        public Guid ID { get; set; }
        public List<PedidoItem> Items { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Items.Sum(e => (e.Quantidade * e.Valor));
            }
        }
        public Pedido(Guid id)
        {
            ID = ID;
            Items = new List<PedidoItem>();
        }

        public void adicionaItem(PedidoItem pedidoItem)
        {
            Items.Add(pedidoItem);
        }
    }
    public class PedidoItem
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }
        public PedidoItem(Guid id, string nome, decimal valor, decimal quantidade)
        {
            ID = ID;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}
