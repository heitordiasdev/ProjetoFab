using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoFabAPI.Models.Domain.Entities;
using ProjetoFabAPI.Repositories.Interface;
using ProjetoFabAPI.Repositories.Repository;

namespace ProjetoFabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeRepository _equipeRepository;

        public EquipeController(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        [HttpPost("RegisterEquipe")]
        public async Task<IActionResult> RegisterEquipe(Equipe equipe)
        {
            if (equipe == null) 
            {
                return BadRequest($"{equipe} não pode ser nulo!!");
            }

            await _equipeRepository.Insert(equipe);
            return Ok("Equipe registrada com sucesso!!");

        }

    }
}
