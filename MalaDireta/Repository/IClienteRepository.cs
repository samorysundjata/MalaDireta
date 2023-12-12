using MalaDireta.Models;

namespace MalaDireta.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> GetClientesEnderecos();
    }
}
