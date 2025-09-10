using System.ComponentModel.DataAnnotations;
using Tours.Models;

namespace Tours.UseCase.CreatePlace;

public record CreatePlacePayload
{
    public string Title { get; init; }
    [Required]
    [MaxLength(20)]

    public string Description { get; init; }

    [Required]
    [MinLength(40)]
    [MaxLength(200)]


}


