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
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Security.Claims;

namespace Server.GamifiedApplicationPhaseFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyUserController : ControllerBase
    {

       
     
        
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

        [HttpGet("GithubResponse")]
        public async Task<IActionResult> GithubResponse()
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

        //    var emailTest = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase)).Value;    
            //claims?.FirstOrDefault(x => x.Type.Equals("UserName", StringComparison.OrdinalIgnoreCase))?.Value;   

            return new JsonResult(claims);

        }
        /*GitHub OAuth*/
        [HttpGet("GitHubSignIn")]
        public IActionResult GitHubSignIn()
        {
            // return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "Github");
            return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("GithubResponse") }, "Github");           
        }


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

           var emailTest = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase)).Value;    
            //claims?.FirstOrDefault(x => x.Type.Equals("UserName", StringComparison.OrdinalIgnoreCase))?.Value;   

            return new JsonResult(claims);

        }

        [HttpGet("GoogleSignIn")]
        public async Task<IActionResult> GoogleSignInAsync()
        {
            // return Challenge(new AuthenticationProperties { RedirectUri = "GoogleResponse" }, "Google");
            return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") }, "Google");
        }


        [HttpGet("TwitterResponse")]
        public async Task<IActionResult> TwitterResponse()
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

        //var emailTest = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase)).Value;    
            //claims?.FirstOrDefault(x => x.Type.Equals("UserName", StringComparison.OrdinalIgnoreCase))?.Value;   

            return new JsonResult(claims);

        }

        [HttpGet("TwitterSignIn")]
        public IActionResult TwitterSignIn()
        {            
            // return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "Twitter");
            return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("TwitterResponse") }, "Twitter");
        }

        
        [HttpGet("LinkedInResponse")]
        public async Task<IActionResult> LinkedInResponse()
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

        //var emailTest = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase)).Value;    
            //claims?.FirstOrDefault(x => x.Type.Equals("UserName", StringComparison.OrdinalIgnoreCase))?.Value;   

            return new JsonResult(claims);

        }
        [HttpGet("LinkedInSignIn")]
        public IActionResult LinkedInSignIn()
        {
            // return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "LinkedIn");
            return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("LinkedInResponse") }, "LinkedIn");
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
            HttpContext.Response.Redirect("/");
            HttpContext.Session.Clear();          
          
            
        }

    }



    /*Test*/
   

}
