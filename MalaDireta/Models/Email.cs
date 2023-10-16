using System.Text.RegularExpressions;

namespace MalaDireta.Models
{
    public class Email
    {
        public Email(string address)
        {
            Address = address.Trim().ToLower();
            var regex = new Regex(@"^([\w\.\-...");
            if (regex.IsMatch(Address) == false)
                throw new Exception("Email inválido");

        }
        public string Address { get; }

        //public static implicit operator Email(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
