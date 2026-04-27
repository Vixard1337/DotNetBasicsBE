namespace DotNetBasicsBE.Domain;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;

    // Polymorphism: każda klasa dziedzicząca może zwrócić własny opis.
    public virtual string GetDescription() => $"Vehicle: {Brand}";
}
