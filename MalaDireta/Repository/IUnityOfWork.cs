namespace MalaDireta.Repository
{
    public interface IUnityOfWork
    {
        IClienteRepository ClienteRepository { get; }

        IEnderecoRepository EnderecoRepository { get; }

        Task Commit();
    }
}
