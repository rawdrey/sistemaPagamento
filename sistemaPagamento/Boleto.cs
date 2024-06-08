using System;

namespace sistemaPagamento
{
    class Boleto : Transacao
    {
        public string CodigoBarras { get; set; }

        public Boleto(string idTransacao, decimal valor, DateTime dataTransacao, string codigoBarras)
            : base(idTransacao, valor, dataTransacao)
        {
            CodigoBarras = codigoBarras;
        }

        public override decimal CalcularTaxa()
        {
            return 5.00m;
        }
    }
}
