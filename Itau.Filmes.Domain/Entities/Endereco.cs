using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Endereco: Base
    {
        public string dsEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
