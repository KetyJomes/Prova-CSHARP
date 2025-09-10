
using Microsoft.AspNetCore.Identity;

namespace Tours.Models;

public class User
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public Place place { get; set; }
    public ICollection<Place> places { get; set; } = [];
}