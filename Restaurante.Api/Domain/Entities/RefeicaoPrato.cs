namespace Restaurante.Api.Domain.Entities
{
    public class RefeicaoPrato
    {
        public int Id { get; set; }
        public int PratoId { get; set; }
        public int RefeicaoId { get; set; }
        public bool Ativo { get; set; }

        public Prato Prato { get; set; }
        public Refeicao Refeicao { get; set; }
    }
}
