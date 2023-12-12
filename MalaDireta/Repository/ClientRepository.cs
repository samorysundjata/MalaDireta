using MalaDireta.Context;
using MalaDireta.Models;
using System.Linq.Expressions;

namespace MalaDireta.Repository
{
    public class ClientRepository : Repository<Cliente> , IClienteRepository
    {
        public ClientRepository(AppDbContext context) : base(context)
        {           
        }

        public void Add(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Cliente> Get()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(Expression<Func<Cliente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
