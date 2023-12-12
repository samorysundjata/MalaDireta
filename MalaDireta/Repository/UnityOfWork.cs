using MalaDireta.Context;

namespace MalaDireta.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private ClientRepository _clientRepository;

        private EnderecoRepository _enderecoRepository;

        public AppDbContext _context { get; set; }

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IClienteRepository ClienteRepository
        {
            get
            {
                return _clientRepository = _clientRepository ?? new ClientRepository(_context);
            }
        }

        public IEnderecoRepository EnderecoRepository
        {
            get
            {
                return _enderecoRepository = _enderecoRepository ?? new EnderecoRepository(_context);
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose() => _context.Dispose();
    }
}
