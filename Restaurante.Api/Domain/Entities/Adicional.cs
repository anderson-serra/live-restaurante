﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Domain.Entities
{
    public class Adicional
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public ICollection<PratoAdicional> PratoAdicionais { get; set; }
    }
}
