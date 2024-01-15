using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Repository
{
    public class ClientRepository : Repository<Cliente>, IClienteRepository
    {
        Task<IEnumerable<Cliente>> IClienteRepository.ClientesEnderecos => throw new NotImplementedException();

        public ClientRepository(AppDbContext context) : base(context)
        {
        }

        void IClienteRepository.Delete(Task<Cliente> cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> ClientesEnderecos()
        {
            return await Get().OrderBy(c => c.Endereco).ToListAsync();
        }
    }
}
