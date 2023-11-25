using Microsoft.AspNetCore.Mvc;

namespace SmartShcool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {      
        public ProfessorController()
        {
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}