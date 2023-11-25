using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartShcool.API.Models;

namespace SmartShcool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {      
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Ze bucetas",
                Sobrenome = "CU",
                Telefone = "21 980822907"
            }
        };
        public AlunoController()
        {
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var obj = Alunos.FirstOrDefault(x => x.Id == id);
            if(obj == null) return BadRequest("Aluno não encontrado ");
            
            return Ok(obj);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var obj = Alunos.FirstOrDefault(x => x.Nome.Contains(nome) && x.Nome.Contains(sobrenome));
            if(obj == null) return BadRequest("Aluno não encontrado ");
            
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {  
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {  
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {  
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {  
            return Ok();
        }
    }
}