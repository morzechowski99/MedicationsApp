using MedicationsApp.Core.Exceptions;

namespace MedicationsApp.Core.Prescription;

//value object
public record PrescriptionValidity
{
    public DateOnly ValidFrom { get; }
    public DateOnly ValidTo { get;}

    public PrescriptionValidity(DateOnly validFrom, DateOnly validTo)
    {
        if (validTo < validFrom)
            throw new InvalidPrescriptionValidityException("valid to must be greater than valid from");
        if (validTo < DateOnly.FromDateTime(DateTime.Today))
            throw new InvalidPrescriptionValidityException("valid to must be grater than today");

        ValidFrom = validFrom;
        ValidTo = validTo;
    }
}