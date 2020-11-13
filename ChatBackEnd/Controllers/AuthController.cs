using CharCommonLib.Models;
using ChatBackEnd.Repository.Interfaces;
using ChatCommonLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IUserRepositry repository;

        public AuthController(IUserRepositry repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public User Post([FromBody] Account account)
        {
            return repository.Login(account.Login, account.Password);
            
        }
    }
}
