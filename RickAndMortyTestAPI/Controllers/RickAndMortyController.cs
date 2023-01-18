using RickAndMortyTestAPI.Data;
using RickAndMortyTestAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RickAndMortyTestAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RickAndMortyController : ControllerBase
    {
        private readonly IRickAndMortyRepository repository;

        public RickAndMortyController(IRickAndMortyRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("person")]
        public async Task<IActionResult> GetPerson([FromQuery] string name)
        {
            JsonPerson data = await repository.GetPerson(name);
            if (data.People?.Any() == true)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpPost("check-person")]
        public async Task<IActionResult> CheckPerson([FromQuery] string personName, [FromQuery] string episodeName)
        {
            var inEpisode = await repository.CheckPerson(personName, episodeName);
            if (inEpisode != null)
            {
                return Ok(inEpisode);
            }
            return NotFound();
        }
    }
}