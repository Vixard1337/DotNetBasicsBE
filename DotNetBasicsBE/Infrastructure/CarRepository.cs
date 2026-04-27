using DotNetBasicsBE.Data;
using DotNetBasicsBE.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotNetBasicsBE.Infrastructure;

public class CarRepository(AppDbContext dbContext) : ICarRepository
{
    public async Task<List<Car>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Cars
            .OrderBy(c => c.Brand)
            .ThenBy(c => c.Model)
            .ToListAsync(cancellationToken);
    }

    public async Task<Car?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Cars.FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Car> AddAsync(Car car, CancellationToken cancellationToken = default)
    {
        dbContext.Cars.Add(car);
        await dbContext.SaveChangesAsync(cancellationToken);
        return car;
    }

    public async Task<bool> UpdateAsync(Car car, CancellationToken cancellationToken = default)
    {
        var exists = await dbContext.Cars.AnyAsync(c => c.Id == car.Id, cancellationToken);
        if (!exists)
        {
            return false;
        }

        dbContext.Cars.Update(car);
        await dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var entity = await dbContext.Cars.FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
        if (entity is null)
        {
            return false;
        }

        dbContext.Cars.Remove(entity);
        await dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }
}
