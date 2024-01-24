﻿using MalaDireta.Services;

namespace MalaDiretaTests
{
    internal static class ResultsFixture
    {
        public static ICollection<ViaCepResult> GetSampleResults() =>
            new List<ViaCepResult>
            {
                new ViaCepResult
                {
                    Unit = "Any",
                    City = "São Paulo",
                    Complement = "",
                    GIACode = 1,
                    IBGECode = 1,
                    Neighborhood = "Centro",
                    StateInitials = "SP",
                    Street = "Rua Direita",
                    ZipCode = "12345-678"
                },
                new ViaCepResult
                {
                    Unit = "",
                    City = "São Paulo",
                    Complement = "",
                    GIACode = null,
                    IBGECode = 1,
                    Neighborhood = "Centro",
                    StateInitials = "SP",
                    Street = "Rua Direita",
                    ZipCode = "45632-870"
                },
                new ViaCepResult
                {
                    Unit = "",
                    City = "São Paulo",
                    Complement = "",
                    GIACode = 12,
                    IBGECode = 123,
                    Neighborhood = "Centro",
                    StateInitials = "SP",
                    Street = "Rua Direita",
                    ZipCode = "98765-432"
                }
            };
    }
}
