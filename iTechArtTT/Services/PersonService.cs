using System.Xml;
using System.Xml.Serialization;
using Ganss.Excel;
using iTechArtTT.Models;
using iTechArtTT.Repositories;

namespace iTechArtTT.Services;

public class PersonService:IPersonService
{
    private readonly IGenericRepository<Person> _personRepository;

    public PersonService(IGenericRepository<Person> personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<string> AddPersons(string path)
    {
        var persons = new List<Person>(); 
        if (path.EndsWith("csv"))
        {
             var personList =  from line in File.ReadAllLines(path).Skip(1)
                let columns = line.Split(',')
                select new Person()
                {
                    PersonName = columns[0],
                    Age = int.Parse(columns[1]),
                    Pet1 = columns[2],
                    Pet1Type = columns[3],
                    Pet2 = columns[4],
                    Pet2Type = columns[5],
                    Pet3 = columns[6],
                    Pet3Type = columns[7]
                };
             persons = personList.ToList();
        }
        else
        {
            persons = new ExcelMapper(path).Fetch<Person>().ToList();
        }
        await _personRepository.Create(persons);
        return "Successful import!";
    }

    public async Task<string> GetPersons(string path)
    {
        var persons = await _personRepository.ReadAll();
        var xmlSerializer = new XmlSerializer(typeof(List<Person>));
        using (var writer = new StreamWriter(path))
        {
            xmlSerializer.Serialize(writer, persons);
        }
        return "Successful export!";
    }
}