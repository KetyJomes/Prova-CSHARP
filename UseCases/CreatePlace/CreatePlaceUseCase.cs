using Microsoft.EntityFrameworkCore;
using Tours.Models;

namespace Tours.UseCase.CreatePlace;

public class CreatePlaceUseCasa(toursDbContext ctx)

{
    public async Task<Results<CreatePlace>> Do(CreatePlacePayload payload)
    {
        var place = new Place
        {
            Title = payload.Title

        };

        await placeService.Create(place);

        return Results<CreatePlaceResponse>.Success(new());
    }
}