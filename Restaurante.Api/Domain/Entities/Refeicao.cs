using System;

namespace Restaurante.Api.Domain.Entities
{
    public class Refeicao
    {
        public int Id { get; set; }
        public string NomeRefeicao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
