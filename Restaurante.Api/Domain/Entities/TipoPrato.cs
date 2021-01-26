using System.Collections.Generic;

namespace Restaurante.Api.Domain.Entities
{
    public class TipoPrato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Prato> Pratos { get; set; }
    }
}
