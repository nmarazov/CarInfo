using System;

namespace Models.Contracts
{
    public interface ICar : IExpirationDate
    {
        int Id { get; set; }

        string Make { get; set; }

        string Model { get; set; }

        string RegistrationNumber { get; set; }

        string VinNumber { get; set; }

        DateTime YearOfProduction { get; set; }
    }
}
