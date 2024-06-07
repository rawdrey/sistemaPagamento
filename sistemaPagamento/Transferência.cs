using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPagamento
{
    class Transferência
: Transacao
    {
        public string NumeroContaOrigem { get; set; }
        public string NumeroContaDestino { get; set; }
        public TransferenciaBancaria(string idTransacao, decimal valor, DateTime dataTransacao, string numeroContaOrigem, string numeroContaDestino)
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