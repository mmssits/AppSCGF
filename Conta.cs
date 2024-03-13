using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancas
{
    public class Conta
    {
        public string Nome {  get; set; }
        public double Saldo { get; set; }
        public List<Transacao> Transacoes { get; set; }

        public Conta(string nome) 
        {
            this.Nome = nome;
            this.Saldo = 0;
            Transacoes = new List<Transacao>();
        }

        public void AdicionarTransacao(double valor, string tipo)
        {
            Transacao transacao = new Transacao(valor, DateTime.Now, tipo);
            Transacoes.Add(transacao);
        }

        public double CalcularSaldo()
        {
            foreach (var transacao in Transacoes)
            {
                if (transacao.Tipo == "Despesa")
                {
                    this.Saldo -= transacao.Valor;
                }
                else
                {
                    this.Saldo += transacao.Valor;
                }
                
            }

            return this.Saldo;
        }

        public void ListarTransacoes()
        {
            Console.WriteLine("Listando transações da conta: {this.Nome}\n");

            foreach (var transacao in Transacoes)
            {
                Console.WriteLine($"Data: {transacao.Date} | Valor: {transacao.Valor} | Tipo: {transacao.Tipo}");
            }

            Console.WriteLine("Listagem finalizada.");
        }
    }
}
