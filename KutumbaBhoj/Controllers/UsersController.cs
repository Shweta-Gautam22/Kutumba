using KutumbaBhoj.Application.Services;
using KutumbaBhoj.Domain.Models;
using KutumbaBhoj.Infrastructure.DbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KutumbaBhoj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUsers : ControllerBase
    {
        public static User user = new User();

        private readonly IUsers _services;

        private readonly IConfiguration _configuration;
        public ServiceUsers(IUsers _services, IConfiguration configuration )
        {
            _configuration = configuration;
            _services = _services;
        }



        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
            
            user.Username = request.Username;
            user.Password = passwordHash;
            user.ContactInformation = request.ContactInformation;

            return Ok(User);
        }

        [HttpPost("login")]
        public async Task <ActionResult<User>>Login(User request)
        {
            if (user.Username != request.Username)
            {
                return BadRequest("User not found!");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
            {
                return BadRequest("Wrong Password!");
            }

            string token = CreateToken(user);

            return Ok(token);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
           {
               new Claim(ClaimTypes.Name, user.Username)
           };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }


    }
}

