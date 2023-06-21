using MalaDireta.Models;

namespace MalaDireta.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer, string audience, UserModel user);
    }
}
