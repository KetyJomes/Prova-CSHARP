namespace Tours.Models;

public class Place
{
    public Guid ID { get; set;}
    public string Title { get; set; }
    public string Description { get; set; }
    public User user { get; set; }
    public ICollection<PlacePoint> placesPoints { get; set; } = [];
}
