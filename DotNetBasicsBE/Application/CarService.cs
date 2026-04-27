using DotNetBasicsBE.Domain;
using DotNetBasicsBE.DTOs;
using DotNetBasicsBE.Infrastructure;

namespace DotNetBasicsBE.Application;

public class CarService(ICarRepository repository) : ICarService
{
    public async Task<IReadOnlyList<CarDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var cars = await repository.GetAllAsync(cancellationToken);
        return cars.Select(ToDto).ToList();
    }

    public async Task<CarDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var car = await repository.GetByIdAsync(id, cancellationToken);
        return car is null ? null : ToDto(car);
    }

    public async Task<CarDto> CreateAsync(UpsertCarDto dto, CancellationToken cancellationToken = default)
    {
        var entity = new Car
        {
            Brand = dto.Brand,
            Model = dto.Model,
            Year = dto.Year
        };

        var created = await repository.AddAsync(entity, cancellationToken);
        return ToDto(created);
    }

    public async Task<bool> UpdateAsync(int id, UpsertCarDto dto, CancellationToken cancellationToken = default)
    {
        var existing = await repository.GetByIdAsync(id, cancellationToken);
        if (existing is null)
        {
            return false;
        }

        existing.Brand = dto.Brand;
        existing.Model = dto.Model;
        existing.Year = dto.Year;

        return await repository.UpdateAsync(existing, cancellationToken);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        return await repository.DeleteAsync(id, cancellationToken);
    }

    private static CarDto ToDto(Car car) => new(car.Id, car.Brand, car.Model, car.Year);
}
