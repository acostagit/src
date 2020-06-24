using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Locacao: Base
    {
        public int FilmeId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Decimal PrecoDiaria { get; set; }
        //public Enum EnumSituacao { get; set; }

        public Filme Filme { get; set; }
        public Cliente Cliente { get; set; }
    }
}
