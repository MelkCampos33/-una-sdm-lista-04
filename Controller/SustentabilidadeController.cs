using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] Dicas = new[]
        {
            "Use transporte público sempre que possível.",
            "Reduza o consumo de plástico descartável.",
            "Prefira produtos com embalagem reciclável.",
            "Economize energia desligando aparelhos da tomada.",
            "Utilize bicicleta para trajetos curtos.",
            "Evite desperdício de água no dia a dia."
        };

        private static readonly Random random = new Random();

        [HttpGet]
        public ActionResult<string> Get()
        {
            var dica = Dicas[random.Next(Dicas.Length)];
            return Ok(dica);
        }
    }
}