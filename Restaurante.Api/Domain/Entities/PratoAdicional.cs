namespace Restaurante.Api.Domain.Entities
{
    public class PratoAdicional
    {
        public int Id { get; set; }
        public int PratoId { get; set; }
        public int AdicionalId { get; set; }

        public Prato Prato { get; set; }
        public Adicional Adicional { get; set; }
    }
}
