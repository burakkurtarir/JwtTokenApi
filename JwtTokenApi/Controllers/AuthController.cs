using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JwtTokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("GetUserToken")]
        public ActionResult GetUserToken()
        {
            //JWT
            //Security key
            string securityKey = "super_secret_security_key";

            //Synmetric security key
            var synmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            //Signing credentials
            var signingCredentials = new SigningCredentials(synmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            //Add Claims
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, "User"));
            claims.Add(new Claim("CustomClaim", "CustomClaimForUser"));

            //Create Token
            var token = new JwtSecurityToken(
                issuer: "smesk.in",
                audience: "readers",
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signingCredentials,
                claims: claims
                );

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }

        [HttpGet("GetAdminToken")]
        public ActionResult GetAdminToken()
        {
            //JWT
            //Security key
            string securityKey = "super_secret_security_key";

            //Synmetric security key
            var synmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            //Signing credentials
            var signingCredentials = new SigningCredentials(synmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            //Add Claims
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            claims.Add(new Claim("CustomClaim", "CustomClaimForAdmin"));

            //Create Token
            var token = new JwtSecurityToken(
                issuer: "smesk.in",
                audience: "readers",
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signingCredentials,
                claims: claims
                );

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}