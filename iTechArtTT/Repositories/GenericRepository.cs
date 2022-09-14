using iTechArtTT.Context;
using Microsoft.EntityFrameworkCore;

namespace iTechArtTT.Repositories;

public class GenericRepository<T>: IGenericRepository<T> where T : class
{ 
    private readonly IDataContext _dataContext;
    private readonly DbSet<T> dbSet;

    public GenericRepository(IDataContext dataContext)
    {
        _dataContext = dataContext;
        dbSet = _dataContext.Set<T>();
    }
    public async Task<int> Create(List<T> entity)
    {
        await dbSet.AddRangeAsync(entity);
        return await _dataContext.ContextSaveChanges();
    }

    public async Task<List<T>> ReadAll()
    {
        return await dbSet.AsNoTracking().ToListAsync();
    }
}

