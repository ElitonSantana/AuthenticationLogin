using AuthenticationLogin.Controllers;
using AuthenticationLogin.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace AuthenticationLogin.Validators
{
    public class AuthenticationJWT : ClaimsPrincipal
    {
        private readonly string _secretkey;

        public AuthenticationJWT(string secretkey)
        {
            _secretkey = secretkey;
        }

        public string Authenticate(string username, string password)
        {
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_secretkey);

            SigningCredentials signingCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature
                );

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken
            (
                claims: new List<Claim>()
                {
                    new Claim("UserId",username),
                    new Claim("Email",password)
                },
                expires: DateTime.UtcNow.AddMinutes(2),
                signingCredentials: signingCredentials

            );

            return jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);
        }

        public User GetUser(ClaimsIdentity claim)
        {
            User user = new User();

            if (claim != null)
            {
                user.UserId = Convert.ToInt32(claim.FindFirst("UserId").Value);
                user.Email = claim.FindFirst("Email").Value;
            }

            return user;
        }

    }
}
