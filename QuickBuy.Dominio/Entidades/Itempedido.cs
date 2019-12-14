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
            throw new NotImplementedException();
        }


    }
}