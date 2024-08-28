using System.ComponentModel.DataAnnotations;

namespace GameStore.Models;

public class GameDetails
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a valid name")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Please select a genre")]
    public string? GenreId { get; set; }

    [Required]
    [Range(1, 100, ErrorMessage = "Please enter a price between 1 and 100")]
    public decimal Price { get; set; }

    [Required]
    public DateOnly ReleaseDate { get; set; }
}
