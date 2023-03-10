using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFabAPI.Models.Data.Contexto;
using ProjetoFabAPI.Models.Domain.Entities;


namespace ProjetoFabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly DataContexto _dataContexto;

        public FuncionarioController(DataContexto dataContexto)
        {
            _dataContexto = dataContexto;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(Funcionario funcionario) 
        {
            if (funcionario == null)
            {
                return BadRequest();
            }

            if (funcionario.Cargo=="Gerente" && funcionario.Email=="")
            {
                return BadRequest($"{funcionario.Email} não pode ser nulo quando seu cargo é gerente!!");
            }

            await _dataContexto.funcionarios.AddAsync(funcionario);
            await _dataContexto.SaveChangesAsync();
            return Ok("Funcionario registrado com sucesso!!");
        }

        [HttpGet("AllFuncionarios")]
        public async Task<IActionResult> TodosOsFuncionarios() 
        {
            var FuncionarioModel = await _dataContexto.funcionarios.ToListAsync();
            return Ok(FuncionarioModel);
        }

    
    }
}
