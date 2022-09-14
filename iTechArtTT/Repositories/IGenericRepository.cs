namespace iTechArtTT.Repositories;

public interface IGenericRepository<T>
{
    public Task<int> Create(List<T> entity);
    public Task<List<T>> ReadAll();
}