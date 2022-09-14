using iTechArtTT.Models;
using iTechArtTT.Services;
using Microsoft.AspNetCore.Mvc;

namespace iTechArtTT.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PersonController:ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }
    [HttpPost]
    public async Task<IActionResult> ImportPersonData(string path)
    {
        return Ok(await _personService.AddPersons(path));
    }

    [HttpGet]
    public async Task<IActionResult> ExportPersonData(string path)
    {
        return Ok(await _personService.GetPersons(path));
    }
}