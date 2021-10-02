using csharpjwt.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace csharpjwt.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
     [Authorize]

    public class AgentController : ControllerBase
    {
        private IConfiguration _config;
        SQLHelpers.AgentSQL Sqlhelpers = new SQLHelpers.AgentSQL();
        public AgentController(IConfiguration config)
        {
            _config = config;
        }
     //  [AllowAnonymous]
    //    [Authorize]
        [HttpGet]
        public IActionResult GeAgentDashBoard()
        {

            var companyclients = Sqlhelpers.GetAgentDashBoard(1, 9, 2021);

            return Ok(companyclients);

        }

     
    }
}