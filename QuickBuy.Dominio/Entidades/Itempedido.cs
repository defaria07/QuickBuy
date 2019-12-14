using System;

namespace QuickBuy.Dominio.Entidades
{
    public class Itempedido : Entidade
    {
        public int id { get; set; }
        public int prodid { get; set; }
        public int quantiprod { get; set; }

        public override void Validacao()
        {
            if (id == 0)
                AdicionarCritica("Não foi idenficado qual o produto");
            if (quantiprod == 0)
                AdicionarCritica("Quantidade não foi informada");

        }


    }
}