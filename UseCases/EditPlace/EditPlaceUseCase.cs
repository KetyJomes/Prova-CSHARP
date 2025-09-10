using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.AppConfig;
using Tours.Models;
using Tours.UseCase.EditPlace;

namespace Tours.Usecase.EditPlace;

public class EditPlaceUseCase(toursDbContext ctx)
{
    public async Task<Results<EditPlaceResponse>> Do(EditPlacePayload payload)
    {
        var place = await ctx.Places.FirstOrDefaultAsync(p => p.ID == payload.PlaceID && p = p.ID == payload.PlacePointID);
        var users = place.userID;

        if (users == payload.userID)
        {
            place.Title = payload.NewTitle;
            place.Description = payload.NewDescription;

            await ctx.SaveChangesAsync();

            return Result<EditPlaceResponse>.Success(null);
        }
            return Result<EditPlaceResponse>.Fail("Id invalid");


    }
}