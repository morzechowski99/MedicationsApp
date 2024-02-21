namespace MedicationsApp.Core.Exceptions;

public class InvalidPrescriptionValidityException : Exception
{
    public InvalidPrescriptionValidityException()
    {
        
    }

    public InvalidPrescriptionValidityException(string message) : base(message)
    {
        
    }
}