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
        model.Entity<PlacePoint>()
        .HasOne(p => p.placesTitle)
        .WithMany(p => p.placesPoints)
        .HasForeignKey(t => t.placesTitle)
        .OnDelete(DeleteBehavior.NoAction);

        model.Entity<User>();

        model.Entity<Place>();
    }
}