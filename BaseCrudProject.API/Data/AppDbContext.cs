using BaseCrudProject.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseCrudProject.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Person> Persons {get; set;}
}
