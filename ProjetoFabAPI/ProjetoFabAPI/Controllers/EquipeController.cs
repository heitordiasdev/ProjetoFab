using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFabAPI.Models.Data.Contexto;
using ProjetoFabAPI.Models.Domain.Entities;

namespace ProjetoFabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        private readonly DataContexto _dataContexto;

        public EquipeController(DataContexto dataContexto)
        {
            _dataContexto = dataContexto;
        }

        [HttpPost("RegisterEquipe")]
        public async Task<IActionResult> RegisterEquipe(EquipeSerializer equipeSerializer)
        {
            if (equipeSerializer == null) 
            {
                return BadRequest($"{equipeSerializer} não pode ser nulo!!");
            }

            Equipe equipe = new Equipe();
            equipe.Setor = equipeSerializer.Setor;
            equipe.NomeEquipe = equipeSerializer.NomeEquipe;

            await _dataContexto.equipes.AddAsync(equipe);
            await _dataContexto.SaveChangesAsync();
            return Ok("Equipe registrada com sucesso!!");

        }

        [HttpGet("AllEquipes")]
        public async Task<IActionResult> TodosAsEquipes()
        {
            var equipesModel = await _dataContexto.equipes.ToListAsync();
            return Ok(equipesModel);
        }
    }
}
