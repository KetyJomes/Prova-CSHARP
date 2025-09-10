using Tours.Models;

namespace Tours.UseCase.GetPlace;

public record GetPlaceResponse
(
    string Title,
    string Description,
    string Name,
    IEnumerable<PlacePoint> PlacePoints

);
