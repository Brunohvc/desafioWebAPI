using API2.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Tests
{
    [TestClass]
    public class PedidoTests
    {
        [TestMethod]
        public void valorTotalTest()
        {
            var pedido = new Pedido(Guid.NewGuid());
            var pedidoItem1 = new PedidoItem(Guid.NewGuid(), "ITEM 1", (decimal)9.99, 3);
            var pedidoItem2 = new PedidoItem(Guid.NewGuid(), "ITEM 2", (decimal)4.99, 2);

            pedido.adicionaItem(pedidoItem1);
            pedido.adicionaItem(pedidoItem2);

            Assert.AreEqual((decimal)39.95, pedido.ValorTotal);
            Assert.AreNotEqual((decimal)40, pedido.ValorTotal);
        }
    }
}
