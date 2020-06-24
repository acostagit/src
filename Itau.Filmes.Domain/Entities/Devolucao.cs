using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Devolucao: Base
    {
        public DateTime DataDevolucao { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorMulta { get; set; }

        public int LocacaoId { get; set; }
        public Locacao Locacao { get; set; }
    }
}
