using DotNetBasicsBE.Domain;

namespace DotNetBasicsBE.Infrastructure;

public interface ICarRepository
{
    Task<List<Car>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Car?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Car> AddAsync(Car car, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(Car car, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}
