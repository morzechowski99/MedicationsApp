namespace MedicationsApp.Core.Shared;

//entity
public class Medication
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }

    public Medication(string name)
    {
        Name = name;
    }
}