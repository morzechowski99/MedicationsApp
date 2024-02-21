using MediatR;

namespace MedicationsApp.Application.Commands.AdmitMedication;

public class AdmitMedicationCommand : IRequest<AdmitMedicationCommandResponse>
{
    public Guid PatientId { get; set; }
    public Guid MedicationId { get; set; }
}