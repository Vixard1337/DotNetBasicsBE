using System.ComponentModel.DataAnnotations;

namespace DotNetBasicsBE.DTOs;

public sealed class UpsertCarDto
{
    [Required]
    [StringLength(60)]
    public string Brand { get; set; } = string.Empty;

    [Required]
    [StringLength(60)]
    public string Model { get; set; } = string.Empty;

    [Range(1900, 2100)]
    public int Year { get; set; } = DateTime.UtcNow.Year;
}
