using DotNetBasicsBE.DTOs;

namespace DotNetBasicsBE.Application;

public interface ICarService
{
    Task<IReadOnlyList<CarDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<CarDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<CarDto> CreateAsync(UpsertCarDto dto, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(int id, UpsertCarDto dto, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}
