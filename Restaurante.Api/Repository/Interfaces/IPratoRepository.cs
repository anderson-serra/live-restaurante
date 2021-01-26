using Restaurante.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository.Interfaces
{
    public interface IPratoRepository
    {
        Task CriarPrato(Prato prato);
    }
}
