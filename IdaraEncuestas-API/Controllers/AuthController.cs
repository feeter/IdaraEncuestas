using System.Threading.Tasks;
using IdaraEncuestas_API.Data;
using IdaraEncuestas_API.Dtos;
using IdaraEncuestas_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdaraEncuestas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            this._repo = repo;

        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            //Validar el Request

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExist(userForRegisterDto.Username))
                return BadRequest("Usuario ya Existe");

            var userToCreate = new User
            {
                UserName = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);

        }
    }
}