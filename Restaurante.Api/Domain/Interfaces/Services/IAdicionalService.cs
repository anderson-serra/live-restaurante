using Restaurante.Api.Domain.Entities;
using Restaurante.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Domain.Interfaces.Services
{
   public interface IAdicionalService
    {
        Task CriarAdicional(Adicional adicional);
    }
}
