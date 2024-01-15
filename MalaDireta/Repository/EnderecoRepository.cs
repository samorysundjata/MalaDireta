using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MalaDireta.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Endereco>> GetEnderecos()
        {
            return null;
            //return await Get().Include(x => x.).ToListAsync();
        }

        Endereco IEnderecoRepository.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
