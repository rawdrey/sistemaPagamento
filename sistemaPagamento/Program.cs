using System;
using System.Collections.Generic;

namespace sistemaPagamento
{
    class Program
    {
        static List<Transacao> transacoes = new List<Transacao>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha o tipo de transação: 1- Cartão de crédito, 2- Boleto, 3- Transferência bancária, 4- Sair.");
                int opcao = ObterInt("Opção: ", 1, 4);
                if (opcao == 4) break;

                string idTransacao = Guid.NewGuid().ToString();
                decimal valor = ObterDecimal("Valor: ");
                DateTime dataTransacao = DateTime.Now;

                switch (opcao)
                {
                    case 1:
                        string numeroCartao = ObterString("Número do Cartão: ");
                        string nomeTitular = ObterString("Nome do Titular: ");
                        transacoes.Add(new CartaoCredito(idTransacao, valor, dataTransacao, numeroCartao, nomeTitular));
                        break;
                    case 2:
                        string codigoBarras = ObterString("Código de Barras: ");
                        transacoes.Add(new Boleto(idTransacao, valor, dataTransacao, codigoBarras));
                        break;
                    case 3:
                        string numeroContaOrigem = ObterString("Número da Conta de Origem: ");
                        string numeroContaDestino = ObterString("Número da Conta de Destino: ");
                        transacoes.Add(new Transferencia(idTransacao, valor, dataTransacao, numeroContaOrigem, numeroContaDestino));
                        break;
                }

                Console.WriteLine("Transação registrada com sucesso!");
            }

            foreach (var transacao in transacoes)
            {
                Console.WriteLine($"ID: {transacao.IdTransacao}, Valor: {transacao.Valor:C}, Data: {transacao.DataTransacao}, Taxa: {transacao.CalcularTaxa():C}");
            }
        }

        static int ObterInt(string mensagem, int min, int max)
        {
            int valor;
            do
            {
                Console.Write(mensagem);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max);
            return valor;
        }

        static decimal ObterDecimal(string mensagem)
        {
            decimal valor;
            do
            {
                Console.Write(mensagem);
            } while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0);
            return valor;
        }

        static string ObterString(string mensagem)
        {
            string valor;
            do
            {
                Console.Write(mensagem);
                valor = Console.ReadLine();
            } while (string.IsNullOrEmpty(valor));
            return valor;
        }
    }
}
