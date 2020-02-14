using System.Threading.Tasks;
using FluentValidation.Sample.Domain.User;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Sample.Controllers
{
    // ApiController - 會將400以上httpstatuscode的response body加上ProblemDetail的格式
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            //不受validator影響
            var user = new UserEntity()
            {
                Name = "q",
                Age = 2
            };
            //需要自行驗證
            var validator = new UserValidator();
            bool isValid = validator.Validate(user).IsValid;
            return Ok(user);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]UserEntity user)
        {
            return Ok(user.Name);
        }
    }
}
