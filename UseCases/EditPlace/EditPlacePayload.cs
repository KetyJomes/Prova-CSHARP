using System.ComponentModel.DataAnnotations;
using Tours.Models;

namespace Tours.UseCase.EditPlace;

public record EditPlacePayload
{
    public Guid PlacePointID;
     public Guid PlaceID;
    internal object userID;

    public object NewDescription { get; internal set; }
}