using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Server.GamifiedApplicationPhaseFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyUserController : ControllerBase
    {


        [HttpGet("GoogleSignIn")]
        public async Task GoogleSignIn()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = "/profile"});
        }

        //this is the one that works. Use this one and you're golden. The other ones down below aren't that important. However, they might prove useful in your journey.
        [HttpGet("LinkedInSignIn")]
        public async Task LinkedInSignIn()
        {
            await HttpContext.ChallengeAsync("LinkedIn", properties: new AuthenticationProperties { RedirectUri = "/profile" });
        }

        #region Other linkedin oauth stuff
        //[HttpGet("~/signin")]
        //public async Task<IActionResult> SignIn() => View("SignIn", await HttpContext.GetExternalProvidersAsync());

        [HttpPost("~/signin")]
        public async Task<IActionResult> SignIn([FromForm] string provider)
        {
            // Note: the "provider" parameter corresponds to the external
            // authentication provider choosen by the user agent.
            if (string.IsNullOrWhiteSpace(provider))
            {
                return BadRequest();
            }

            // Instruct the middleware corresponding to the requested external identity
            // provider to redirect the user agent to its own authorization endpoint.
            // Note: the authenticationScheme parameter must match the value configured in Startup.cs
            return Challenge(new AuthenticationProperties { RedirectUri = "/profile" }, provider);
        }

        [HttpGet("~/signout")]
        [HttpPost("~/signout")]
        public IActionResult SignOutCurrentUser()
        {
            // Instruct the cookies middleware to delete the local cookie created
            // when the user agent is redirected from the external identity provider
            // after a successful authentication flow (e.g Google or Facebook).
            return SignOut(new AuthenticationProperties { RedirectUri = "/profile" },
                CookieAuthenticationDefaults.AuthenticationScheme);
        }
        #endregion
    }


}
