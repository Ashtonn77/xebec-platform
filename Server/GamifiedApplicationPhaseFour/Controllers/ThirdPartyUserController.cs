using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections;

namespace Server.GamifiedApplicationPhaseFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyUserController : ControllerBase
    {

       
        [HttpGet("GoogleResponse")]
        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var claims = result.Principal.Identities.FirstOrDefault()
            .Claims.Select(claim => new
            {

                claim.Issuer,
                claim.OriginalIssuer,
                claim.Type,
                claim.Value

            });

            return new JsonResult(claims);

        }
        /*End Google OAuth*/

        //this is the one that works. Use this one and you're golden. The other ones down below aren't that important. However, they might prove useful in your journey.
        // [HttpGet("LinkedInSignIn")]
        // public async Task LinkedInSignIn()
        // {
        //     await HttpContext.ChallengeAsync("LinkedIn", properties: new AuthenticationProperties { RedirectUri = "/profile" });
        // }

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

        #endregion


        /*GitHub OAuth*/
        [HttpGet("GitHubSignIn")]
        public IActionResult GitHubSignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "Github");
        }

        [HttpGet("GoogleSignIn")]
        public IActionResult GoogleSignIn()
        {           
            return Challenge(new AuthenticationProperties { RedirectUri = "/testnavigation" }, "Google");
        }

        [HttpGet("TwitterSignIn")]
        public IActionResult TwitterSignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "Twitter");
        }

        
        [HttpGet("LinkedInSignIn")]
        public IActionResult LinkedInSignIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "LinkedIn");
        }

        [HttpGet("LogOut")]
        public async Task LogOut()
        {
            {
                var siteCookies = HttpContext.Request.Cookies.Where(c => c.Key.Contains(".AspNetCore.") || c.Key.Contains("Microsoft.Authentication"));
                foreach (var cookie in siteCookies)
                {
                    Response.Cookies.Delete(cookie.Key); 
                }
            }

            await HttpContext.SignOutAsync();
            HttpContext.Response.Redirect("/loginbeta");
            HttpContext.Session.Clear();          
          
            
        }




    }

}
