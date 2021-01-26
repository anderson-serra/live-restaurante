using System.Collections.Generic;

namespace Restaurante.Api.Domain.Entities
{
    public class TipoRefeicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Refeicao> Refeicoes { get; set; }
    }
}
