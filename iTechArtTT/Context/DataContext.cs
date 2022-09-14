using iTechArtTT.Models;
using Microsoft.EntityFrameworkCore;

namespace iTechArtTT.Context;

public class DataContext:DbContext,IDataContext
{
    public DbSet<Person> Persons { get; set; }
    public Task<int> ContextSaveChanges()
    {
        return base.SaveChangesAsync();
    }
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
        
    }
}