using Tours.UseCase.CreatePlace;
using Tours.UseCase.GetPlace;

namespace Tours.Endpoints;

public static class PlaceEndpoints
{
    public static void ConfigurePlaceEndpoints(this WebApplication app)
    {
      
        app.MapPost("place", async (
            [FromBody] CreatePlacePayload payload,
            [FromServices] CreatePlaceUseCasa useCase) =>
            {
                var result = await useCase.Do(payload);

                if (result.IsSuccess)
                    return Results.Created();

                return Results.BadRequest(result.Reason);
            });
    }
}