using QuickBuy.Dominio.ObejtodeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Pedido
    {
        public int id { get; set; }
        public DateTime Datapedido { get; set; }
        public int userid { get; set; }

        public DateTime previsaoentrega { get; set; }

        public string estado { get; set; }

        public string cidade { get; set; }

        public string cep { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }
        public int FpagamentoID { get; set; }
        public Formapagamento Fpagamento { get; set; }

        //pedido deve ter 1 ou muitos items
        public ICollection<Itempedido> ItemPedidos { get; set; }

    }
}
