using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Cliente: Base
    {
        public int CodCliente { get; set; }
        public string CPF { get; set; }
        public string dsCliente { get; set; }
        public string dsEndereco { get; set; }
        public string Email { get; set; }
    }
}
