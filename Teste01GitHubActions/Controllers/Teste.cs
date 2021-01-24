using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Teste01GitHubActions.Controllers
{
    [ApiController]
    [Route("teste")]
    public class Teste : Controller
    {
        private readonly IConfiguration configuration;
        public Teste(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult Index() => Ok("Versão 1.0");
        [HttpGet("ambiente")]
        public IActionResult Ambiente() => Ok(configuration.GetSection("ambiente").Value);
    }
}
