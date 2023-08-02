using Jwt_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("Action")]
        public IActionResult Login()
        {
            return Created("",new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet("getall")]
        public IActionResult CustomerList() 
        {
            return Ok("Müşteri Listesine Eriştiniz");
        }
    }
}
