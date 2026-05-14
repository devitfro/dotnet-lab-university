namespace Core.Models;

public abstract class MedicalEntity
{
    public int Id { get; set; }

    public virtual string GetInfo()
    {
        return $"Medical entity #{Id}";
    }

    public abstract decimal GetCost();

}