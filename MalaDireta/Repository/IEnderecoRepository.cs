using MalaDireta.Models;

namespace MalaDireta.Repository
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Endereco Get(int id);

        Task<IEnumerable<Endereco>> GetEnderecos();
    }
}
