using System;

namespace sistemaPagamento
{
    class Transferencia : Transacao
    {
        public string NumeroContaOrigem { get; set; }
        public string NumeroContaDestino { get; set; }

        public Transferencia(string idTransacao, decimal valor, DateTime dataTransacao, string numeroContaOrigem, string numeroContaDestino)
            : base(idTransacao, valor, dataTransacao)
        {
            NumeroContaOrigem = numeroContaOrigem;
            NumeroContaDestino = numeroContaDestino;
        }

        public override decimal CalcularTaxa()
        {
            return 10.00m;
        }
    }
}
