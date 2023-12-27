using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace azure_app_doug.Data
{
 public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

    }

    public DbSet<Person> Persons {get; set;}
    

 }
}