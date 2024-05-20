
namespace TechJobsOOAutoGraded6;

public abstract class JobField
{
    private static int nextId = 1;
    public int Id { get; }
    public string? Value { get; set; }

    public JobField()
    {
        Id = nextId;
        nextId++;
    }

    public JobField(string? value) : this()
    {
        value ??= "";
        Value = value.Length > 0 ? value : "Data not available";
    }

    public override bool Equals(object? obj)
    {
        return obj is JobField field &&
               Id == field.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public override string ToString()
    {
        return Value ?? "No data available";
    }
}
