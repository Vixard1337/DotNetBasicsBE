namespace DotNetBasicsBE.Domain;

public class Car : Vehicle
{
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }

    public override string GetDescription() => $"Car: {Brand} {Model} ({Year})";
}
