namespace Tours.Models;

public class PlacesPoints
{
    public Guid ID { get; set; }
    public string PontsTitle { get; set; }
    public Places places { get; set; }

}