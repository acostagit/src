using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Locacao: Base
    {
        public int IdFilme { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Decimal PrecoDiaria { get; set; }
        public Enum EnumSituacao { get; set; }

        public virtual Filme Filme { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
