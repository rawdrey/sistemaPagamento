using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPagamento
{
    abstract class Transacao
    {
        public string idTransacao { get; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; }
        public Transacao(string idTransacao, decimal valor, DateTime dataTransacao)
        {
            IdTransacao = idTransacao;
            Valor = valor;
            DataTransacao = dataTransacao;
        }
        public virtual decimal CalcularTaxa()
        {
            return 0;
        }
}