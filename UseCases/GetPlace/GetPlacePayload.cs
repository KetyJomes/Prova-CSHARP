using Tours.Models;

namespace Tours.UseCase.GetPlace;

public record GetPlacePayload(
    string Title,
    string  Description,
    PlacePoint PlacePoint,
    string Name
);