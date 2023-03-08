using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoFabAPI.Models.EntitiesModels.Funcionario;

namespace ProjetoFabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(PostFuncionario funcionario) 
        {
            return Ok();
        }

        [HttpPut] 
        public IActionResult Put() 
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete() 
        {
            return Ok();
        }


    }
}
