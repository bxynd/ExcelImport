using iTechArtTT.Models;

namespace iTechArtTT.Services;

public interface IPersonService
{
    Task<string> AddPersons(string path);
    Task<string> GetPersons(string path);
}