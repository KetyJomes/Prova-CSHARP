namespace Tours.Models;

public class Place
{
    public Guid ID { get; set;}
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid userID { get; set; }
    public ICollection<PlacePoint> placesPoints { get; set; } = [];
}
