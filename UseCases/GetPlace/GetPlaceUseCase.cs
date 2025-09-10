namespace Tours.Usecase.GetPlace;

public class GetPlaceUseCase(toursDbContext ctx)
{
    public async Task<Results<GetPlaceResponse>> Do(GetPlacePayload payload)
    {
        var place = await ctx.PlacePoint
        .include(p => p.PontsTitle)
        .FirstOrDefaultAsync(u => u.ID == payload.PlacePoints);



    }
}