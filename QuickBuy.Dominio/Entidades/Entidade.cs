using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagens{ get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagens ?? (_mensagens = new List<string>());  }
        }

        protected void limpaMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string Mensagem)
        {
            MensagemValidacao.Add(Mensagem);
        }
        public abstract void Validacao();
        protected bool EhValido
        {
            
            get { return !MensagemValidacao.Any();  }
        }
    }
}
