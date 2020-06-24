using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Itau.Filmes.Domain.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
