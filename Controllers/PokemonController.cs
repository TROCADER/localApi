using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace localApi.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Pika"},
            new Pokemon() {Name = "Char"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
    }
}
