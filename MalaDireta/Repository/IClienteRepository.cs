using MalaDireta.Models;

namespace MalaDireta.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void Delete(Task<Cliente> cliente);
        Task<IEnumerable<Cliente>> ClientesEnderecos { get; }
    }
}
