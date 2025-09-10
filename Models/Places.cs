namespace Tours.Models;

public class Places
{
    public Guid ID { get; set;}
    public string Title { get; set; }
    public string Description { get; set; }
    public User user { get; set; }
    public ICollection<PlacesPoints> placesPoints { get; set; } = [];
}
