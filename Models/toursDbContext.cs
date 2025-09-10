using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tours.Models;

public class toursDbContext(DbContextOptions<toursDbContext> options) : DbContext(options)
{

}