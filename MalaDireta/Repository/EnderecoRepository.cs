using MalaDireta.Context;
using MalaDireta.Models;
using System.Linq.Expressions;

namespace MalaDireta.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context)
        {

        }

        //public new void Add(Endereco entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public new void Delete(Endereco entity)
        //{
        //    throw new NotImplementedException();
        //}

        public Endereco Get(int id)
        {
            throw new NotImplementedException();
        }

        //public IQueryable<Endereco> Get()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Endereco> GetById(Expression<Func<Endereco, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<IEnumerable<Endereco>> GetEnderecos()
        {
            throw new NotImplementedException();
        }

        //public void Update(Endereco entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
