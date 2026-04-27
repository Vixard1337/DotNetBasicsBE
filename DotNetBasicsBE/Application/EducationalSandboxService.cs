using DotNetBasicsBE.Domain;
using DotNetBasicsBE.DTOs;

namespace DotNetBasicsBE.Application;

public class EducationalSandboxService
{
    public string RunOopDemo()
    {
        Vehicle vehicle = new Car { Brand = "Toyota", Model = "Corolla", Year = 2022 };
        return $"Polymorphism result: {vehicle.GetDescription()}";
    }

    public string RunGcDemo()
    {
        var temporaryObjects = Enumerable.Range(1, 5000).Select(i => new object()).ToList();
        temporaryObjects.Clear();
        GC.Collect();
        return "Created and released 5000 objects. GC.Collect() was called for demo purposes.";
    }

    public string RunLinqDemo(IEnumerable<CarDto> cars)
    {
        var filtered = cars
            .Where(c => c.Year >= 2020)
            .OrderBy(c => c.Brand)
            .ThenBy(c => c.Model)
            .Select(c => $"{c.Brand} {c.Model} ({c.Year})")
            .ToList();

        return filtered.Count == 0
            ? "No cars from 2020+ were found."
            : $"LINQ result: {string.Join(", ", filtered)}";
    }

    public async Task<string> RunAsyncAwaitDemo()
    {
        await Task.Delay(1000);
        return "Async operation finished after 1 second.";
    }

    public string RunDiDemo(ICarService carService)
    {
        return $"DI check: carService resolved successfully ({carService.GetType().Name}).";
    }
}
