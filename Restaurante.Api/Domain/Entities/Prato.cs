using System.Collections.Generic;

namespace Restaurante.Api.Domain.Entities
{
    public class Prato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public int TipoPratoId { get; set; }
        public TipoPrato TipoPrato { get; set; }

        public  ICollection<Refeicao>  Refeicoes { get; set; }
        public ICollection<RefeicaoPrato> RefeicaoPratos { get; set; }
        public ICollection<PratoOpcao> PratoOpcoes { get; set; }
        public ICollection<PratoAdicional> PratoAdicionais { get; set; }
    }
}
