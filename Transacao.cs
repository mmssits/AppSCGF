using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancas
{
    public class Transacao
    {
        public double Valor {  get; set; }
        public DateTime Date { get; set; }
        public string Tipo { get; set; }

        public Transacao(double valor, DateTime date, string tipo) 
        {
            Valor = valor;
            Date = date;
            Tipo = tipo;
        }
    }
}
