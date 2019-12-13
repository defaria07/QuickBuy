using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObejtodeValor
{
    public class Formapagamento
    {
        public int id { get; set; }
        public string nome { get; set; }

        public int descricao { get; set; }

        public bool Ehboleto
        {
            get { return id == (int)Tipoformapagamento.boleto; }
        }
        public bool Ehcartao
        {
            get { return id == (int)Tipoformapagamento.cartaocredito; }
        }
        public bool Ehdeposito
        {
            get { return id == (int)Tipoformapagamento.deposito; }
        }
        public bool Naodefinido
        {
            get { return id == (int)Tipoformapagamento.ndefinido; }
        }
    }   
}
