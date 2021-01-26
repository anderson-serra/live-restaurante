using Restaurante.Api.Domain.Entities;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository.Interfaces
{
    public interface IAdicionalRepository
    {
        Task CriarAdicional(Adicional adicional);
    }
}
