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

        /*Begin Google OAuth*/
        // [HttpGet("GoogleSignIn")]
        // public async Task GoogleSignIn()
        // {
        //     await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme,
        //         new AuthenticationProperties { RedirectUri = "/profileTest" });
        // }

        // [HttpGet("GoogleSignIn")]
        // public IActionResult GoogleSignIn()
        // {
        //     // var properties = new AuthenticationProperties{RedirectUri = Url.Action("GoogleResponse")};
        //     var properties = new AuthenticationProperties{RedirectUri = "/profileTest"};
        //     return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        // }


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

        // [HttpGet("Logout")]
        // public async Task<IActionResult> Logout()
        // {
        //     await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        //     return Ok("");

        // }

        // [HttpGet("Logout")]
        // public async Task Logout()
        // {
        //     Response.Cookies.Delete(CookieAuthenticationDefaults.AuthenticationScheme);
        // }
        // public async Task MyCustomSignOut(string redirectUri)
        // {
        //     // inject the HttpContextAccessor to get "context"
        //     await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //     var prop = new AuthenticationProperties()
        //     {
        //         RedirectUri = redirectUri
        //     };
        //     // after signout this will redirect to your provided target
        //     await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme, prop);
        // }


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
            return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "Google");
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

    }

}
