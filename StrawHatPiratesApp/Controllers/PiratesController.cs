using Microsoft.AspNetCore.Mvc;
using StrawHatPiratesApp.Models;
using System.Collections.Generic;

namespace StrawHatPiratesApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PiratesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pirate>> GetPirates()
        {
            var pirates = new List<Pirate>
            {
                new Pirate { Name = "Monkey D. Luffy", Powers = new List<string> { "Gomu Gomu no Mi", "Haki" } },
                new Pirate { Name = "Roronoa Zoro", Powers = new List<string> { "Santoryu", "Haki" } },
                new Pirate { Name = "Nami", Powers = new List<string> { "Navigation", "Weather Manipulation" } },
                new Pirate { Name = "Usopp", Powers = new List<string> { "Sniping", "Inventing" } },
                new Pirate { Name = "Sanji", Powers = new List<string> { "Black Leg", "Haki" } },
                new Pirate { Name = "Tony Tony Chopper", Powers = new List<string> { "Hito Hito no Mi", "Doctor" } },
                new Pirate { Name = "Nico Robin", Powers = new List<string> { "Hana Hana no Mi", "Archaeology" } },
                new Pirate { Name = "Franky", Powers = new List<string> { "Cyborg", "Engineering" } },
                new Pirate { Name = "Brook", Powers = new List<string> { "Yomi Yomi no Mi", "Music" } },
                new Pirate { Name = "Jinbe", Powers = new List<string> { "Fish-Man Karate", "Haki" } }
            };

            return Ok(pirates);
        }
    }
}