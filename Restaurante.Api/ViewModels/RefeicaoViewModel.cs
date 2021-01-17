using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.ViewModels
{
    public class RefeicaoViewModel
    {
        public int Id { get; set; }
        public string NomeRefeicao { get; set; }
    }
}
