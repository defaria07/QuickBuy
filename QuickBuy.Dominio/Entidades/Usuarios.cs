using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string Sobrenome { get; set; }

        //usuer pode ter 1 ou varios pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validacao()
        {
            if (string.IsNullOrEmpty(email))
                AdicionarCritica("Email não foi informado");
            if (string.IsNullOrEmpty(senha))
                AdicionarCritica("Senha não foi informada");
        }
    }


}
