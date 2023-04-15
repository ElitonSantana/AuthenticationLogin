using AuthenticationLogin.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        #region :: CRUD :: 

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] User user)
        {
            //Service Implementation

            return Ok();
        }

        [Authorize]
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] User user)
        {
            //Service Implementation

            return Ok();
        }

        [HttpGet]
        [Route("GetUserById/{UserId}")]
        public IActionResult GetUserById([FromBody] int UserId)
        {
            //Service Implementation

            return Ok();
        }

        [Authorize]
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete([FromBody] User user)
        {
            //Service Implementation

            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            //Service Implementation

            return Ok();
        }

        #endregion

        #region :: Login ::

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            //Service Implementation

            return Ok();
        }

        #endregion
    }
}
