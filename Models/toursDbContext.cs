using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tours.Models;

public class toursDbContext(DbContextOptions<toursDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Place> Places => Set<Place>();
    public DbSet<PlacePoint> PlacesPoints => Set<PlacePoint>();

    protected override void OModelCreating(ModelBuilder model)
    {
        model.Entity<Place>()
        .HasOne(p => p.)
    }

}