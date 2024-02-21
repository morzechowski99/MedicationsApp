namespace MedicationsApp.Core.Prescription;

public interface IPrescriptionsRepository
{
    Task<IReadOnlyCollection<Prescription>> GetActivePrescriptionsByDate(Guid patientId, DateOnly date);
}