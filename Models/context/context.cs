
using Microsoft.EntityFrameworkCore;

public class Context : DbContext

{

public DbSet <Tbl_Car> Tbl_Cars {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=dbcars;Integrated Security=true");
    }
}