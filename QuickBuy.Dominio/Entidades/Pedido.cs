using QuickBuy.Dominio.ObejtodeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
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

        public override void Validacao()
        {
            limpaMensagensValidacao();
            if (!ItemPedidos.Any())
                AdicionarCritica("Critica - Pedido não pode ficar sem item de pedido");
            if(string.IsNullOrEmpty(cep))
                AdicionarCritica("Critica - Cep não pode ficar vazio");
            if (string.IsNullOrEmpty(cidade))
                AdicionarCritica("Critica - Cidade não pode ficar vazio");
            if (string.IsNullOrEmpty(endereco))
                AdicionarCritica("Critica - Endereço não pode ficar vazio");
            if (string.IsNullOrEmpty(estado))
                AdicionarCritica("Critica - Estado não pode ficar vazio");


        }
    }
}
