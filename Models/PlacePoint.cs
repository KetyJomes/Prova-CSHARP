namespace Tours.Models;

public class PlacePoint
{
    public Guid ID { get; set; }
    public string PontsTitle { get; set; }
    public Place places { get; set; }

}