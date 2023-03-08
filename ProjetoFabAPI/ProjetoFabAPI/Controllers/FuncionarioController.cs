using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoFabAPI.Models.Domain.Entities;
using ProjetoFabAPI.Repositories;
using ProjetoFabAPI.Repositories.Interface;

namespace ProjetoFabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(Funcionario funcionario) 
        {
            if (funcionario == null)
            {
                return BadRequest($"{funcionario} não pode ser nulo!!");
            }
            await _funcionarioRepository.Insert(funcionario);
            return Ok("Funcionario registrado com sucesso!!");
        }
    }
}
