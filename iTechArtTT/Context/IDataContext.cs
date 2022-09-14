using iTechArtTT.Models;
using Microsoft.EntityFrameworkCore;

namespace iTechArtTT.Context;

public interface IDataContext
{
    DbSet<Person> Persons { get; set; }
    Task<int> ContextSaveChanges();
    DbSet<T> Set<T>() where T : class;
}