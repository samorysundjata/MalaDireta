namespace MalaDireta.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        public IClienteRepository ClienteRepository => throw new NotImplementedException();

        public IEnderecoRepository EnderecoRepository => throw new NotImplementedException();

        public Task Commit()
        {
            throw new NotImplementedException();
        }
    }
}
