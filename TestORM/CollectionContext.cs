//use dotnet cli command
//dotnet add package Microsoft.EntityFramework


using BOL;
using Microsoft.EntityFrameworkCore;
namespace DAL;
public class CollectionContext:DbContext{
    public DbSet<Book> Books {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=localhost;port=3306;user=root; password=Anand@137;database=pract";       
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Set Mapping of Table with POCO
        //Relational        instance: Table
        //Object Oriented   instance: POCO Class
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Book>(entity => 
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Price).IsRequired();
        });
        modelBuilder.Entity<Book>().ToTable("NEWBOOKS");
    }
}

