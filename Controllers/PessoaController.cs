using webapi.Model;
using webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController (IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        [Produces(typeof(Pessoa))]
        public IActionResult Get()
        {
            var pessoas = _pessoaRepository.GetAll();

            if (pessoas.Count() == 0)
                return NoContent();
            return Ok(pessoas);
        }
    }
}