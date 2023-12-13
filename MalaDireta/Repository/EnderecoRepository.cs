using MalaDireta.Models;
using System.Linq.Expressions;

namespace MalaDireta.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public void Add(Endereco entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Endereco entity)
        {
            throw new NotImplementedException();
        }

        public Endereco Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Endereco> Get()
        {
            throw new NotImplementedException();
        }

        public Endereco GetById(Expression<Func<Endereco, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Endereco entity)
        {
            throw new NotImplementedException();
        }

        Task<Endereco> IRepository<Endereco>.GetById(Expression<Func<Endereco, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
