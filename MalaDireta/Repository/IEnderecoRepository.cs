using MalaDireta.Models;

namespace MalaDireta.Repository
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Endereco Get(int id);
    }
}
