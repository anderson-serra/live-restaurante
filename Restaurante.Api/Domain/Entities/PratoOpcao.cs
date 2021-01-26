namespace Restaurante.Api.Domain.Entities
{
    public class PratoOpcao
    {
        public int Id { get; set; }
        public int PratoId { get; set; }
        public int OpcaoId { get; set; }

        public Prato Prato { get; set; }
        public Opcao Opcao { get; set; }
    }
}
