using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Filme: Base
    {
        public int CodFilme { get; set; }
        public string dsFilme { get; set; }
        public bool Dublado { get; set; }
    }
}
