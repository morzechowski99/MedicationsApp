using MedicationsApp.Core.Shared;

namespace MedicationsApp.Core.Prescription;

//entity
public class PrescriptionItem
{
    public Guid PrescriptionId { get; }
    public Guid MedicationId { get; }
    public int DailyQuantity { get; }
    public TimeSpan MinimumIntervalBetweenDoses { get; }
    public Medication Medication { get; }

    public PrescriptionItem(Guid prescriptionId, int dailyQuantity, TimeSpan minimumIntervalBetweenDoses, Medication medication)
    {
        PrescriptionId = prescriptionId;

        ArgumentOutOfRangeException.ThrowIfLessThan(dailyQuantity, 1);
        DailyQuantity = dailyQuantity;
        MinimumIntervalBetweenDoses = minimumIntervalBetweenDoses;
        Medication = medication ?? throw new ArgumentNullException(nameof(medication));
        MedicationId = medication.Id;
    }
}