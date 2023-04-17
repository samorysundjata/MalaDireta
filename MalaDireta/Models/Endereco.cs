﻿using System.Security.Cryptography;

namespace MalaDireta.Models
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }
    }
}
