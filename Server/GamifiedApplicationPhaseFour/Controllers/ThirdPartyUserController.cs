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
using XebecPortal.Shared.Security;
using Server.GamifiedApplicationPhaseFour.IRepositories;

namespace Server.GamifiedApplicationPhaseFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdPartyUserController : ControllerBase
    {
        private readonly IUserDb userDb;

        public ThirdPartyUserController(IUserDb userDb)
        {
            this.userDb = userDb;
        }

        [HttpGet("GithubResponse")]
        public async Task<string> GithubResponse()
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

           var email = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase))?.Value;  

            return email;

        }
        /*GitHub OAuth*/
        [HttpGet("GitHubSignIn")]
        public async Task<IActionResult> GitHubSignIn()
        {
            RegisterModel reg = new RegisterModel();
            reg.Password = "P@ssword1";
            reg.Role = "Candidate";
            string email = await GithubResponse();
            if (!string.IsNullOrEmpty(email))
            {                
                //TODO: only add if email not in db
                reg.Email = email;
                AppUser newuser = await userDb.AddUser(reg.Email, reg.Password, reg.Role);
            }

            // return Challenge(new AuthenticationProperties { RedirectUri = "/profileTest" }, "Github");
            return Challenge(new AuthenticationProperties { RedirectUri = "/profile"  }, "Github");
        }


        [HttpGet("GoogleResponse")]
        public async Task<string> GoogleResponse()
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

            var email = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase))?.Value;
            
            return email;

        }

        [HttpGet("GoogleSignIn")]
        public async Task<IActionResult> GoogleSignInAsync()
        {
            RegisterModel reg = new RegisterModel();
            reg.Password = "P@ssword1";
            reg.Role = "Candidate";

            string email = await GoogleResponse();
            if (!string.IsNullOrEmpty(email))
            {
                //TODO: only add if email not in db
                reg.Email = email;
                AppUser newuser = await userDb.AddUser(reg.Email, reg.Password, reg.Role);
            }
            // return Challenge(new AuthenticationProperties { RedirectUri = "GoogleResponse" }, "Google");
            return Challenge(new AuthenticationProperties { RedirectUri = "/profile" }, "Google");
        }


        [HttpGet("TwitterResponse")]
        public async Task<string> TwitterResponse()
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

            var email = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase))?.Value;
            
            return email;

        }

        [HttpGet("TwitterSignIn")]
        public async Task<IActionResult> TwitterSignIn()
        {
            RegisterModel reg = new RegisterModel();
            reg.Password = "P@ssword1";
            reg.Role = "Candidate";

            string email = await TwitterResponse();
            if (!string.IsNullOrEmpty(email))
            {
                //TODO: only add if email not in db
                reg.Email = email;
                AppUser newuser = await userDb.AddUser(reg.Email, reg.Password, reg.Role);
            }
           
            return Challenge(new AuthenticationProperties { RedirectUri = "/profile"  }, "Twitter");
        }


        [HttpGet("LinkedInResponse")]
        public async Task<string> LinkedInResponse()
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

            var email = claims?.First(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", StringComparison.OrdinalIgnoreCase))?.Value;
            
            return email;

        }
        [HttpGet("LinkedInSignIn")]
        public async Task<IActionResult> LinkedInSignIn()
        {
            RegisterModel reg = new RegisterModel();
            reg.Password = "P@ssword1";
            reg.Role = "Candidate";

            string email = await LinkedInResponse();
            if (!string.IsNullOrEmpty(email))
            {
                //TODO: only add if email not in db
                reg.Email = email;
                AppUser newuser = await userDb.AddUser(reg.Email, reg.Password, reg.Role);
            }
          
            return Challenge(new AuthenticationProperties { RedirectUri = "/profile" }, "LinkedIn");
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


}
