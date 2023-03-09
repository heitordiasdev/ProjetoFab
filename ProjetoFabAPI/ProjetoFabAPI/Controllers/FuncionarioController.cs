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
            if (funcionario.Cargo=="Gerente" && funcionario.Email=="")
            {
                return BadRequest($"{funcionario.Email} não pode ser nulo quando seu cargo é gerente!!");
            }
            await _funcionarioRepository.Insert(funcionario);
            return Ok("Funcionario registrado com sucesso!!");
        }

        [HttpGet("AllFuncionarios")]
        public async Task<IActionResult> TodosOsFuncionarios() 
        {
            var resultado = await _funcionarioRepository.GetAll();
            return Ok(resultado.ToList());
        }
    }
}
