using System;
using System.Collections.Generic;

namespace Restaurante.Api.Domain.Entities
{
    public class Refeicao
    {
        public int Id { get; set; }
        public string NomeRefeicao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public int TipoRefeicaoId { get; set; }
        public TipoRefeicao TipoRefeicao { get; set; }

        public ICollection<RefeicaoPrato> RefeicaoPratos { get; set; }
    }
}
