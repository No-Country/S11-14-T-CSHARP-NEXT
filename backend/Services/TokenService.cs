using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using S11.Data.Models;

namespace S11.Services;

public class TokenService
{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public TokenService(UserManager<User> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

    public async Task<string> GenerateToken(User user, IList<string> roles)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.GivenName, user.FullName)
        };

       // var roles = await _userManager.GetRolesAsync(user);
        
        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["TokenKey"]));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

        var tokenOptions = new JwtSecurityToken(issuer: null, audience: null, claims: claims,
            expires: DateTime.Now.AddDays(30), signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }
}