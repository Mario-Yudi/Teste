using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaiorNumeroController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly int[] Numeros = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

     

        private readonly ILogger<MaiorNumeroController> _logger;

        public MaiorNumeroController(ILogger<MaiorNumeroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MaiorNumero> Get()
        {
            var rng = new Random();
            var MaxValue = Numeros.Max()-1;
            return Enumerable.Range(0, 1).Select(index => new MaiorNumero
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)],
                
                NumeroNovo = Numeros[MaxValue]
            })
            .ToArray();
        }

    }
}
