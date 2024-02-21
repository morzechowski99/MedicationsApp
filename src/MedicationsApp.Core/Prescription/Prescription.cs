namespace MedicationsApp.Core.Prescription;

//entity
public class Prescription
{
    private readonly List<PrescriptionItem> _medications = new();

    public Guid Id { get; } = Guid.NewGuid();
    public Guid PatientId { get; }
    public PrescriptionValidity Validity { get; }
    public IReadOnlyCollection<PrescriptionItem> Medications => _medications;

    public Prescription(Guid patientId, PrescriptionValidity validity)
    {
        PatientId = patientId;
        Validity = validity ?? throw new ArgumentNullException(nameof(validity));
    }
}