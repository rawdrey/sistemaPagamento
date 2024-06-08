using System;

namespace sistemaPagamento
{
    class CartaoCredito : Transacao
    {
        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }

        public CartaoCredito(string idTransacao, decimal valor, DateTime dataTransacao, string numeroCartao, string nomeTitular)
            : base(idTransacao, valor, dataTransacao)
        {
            NumeroCartao = numeroCartao;
            NomeTitular = nomeTitular;
        }

        public override decimal CalcularTaxa()
        {
            return Valor * 0.02m;
        }
    }
}
