using System;

namespace Models.Contracts
{
    public interface IExpirationDate
    {
        DateTime TechnicalInspectionDueDate { get; set; }

        DateTime PrimaryInsuranceDueDate { get; set; }

        DateTime? AdditionalInsuranceDueDate { get; set; }
    }
}
