using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
public class AuthService {
    private readonly IConfiguration _config;
    public AuthService(IConfiguration config) => _config = config;
    public string Hash(string p) => BCrypt.Net.BCrypt.HashPassword(p);
    public bool Verify(string p, string h) => BCrypt.Net.BCrypt.Verify(p, h);
    public string GenerateToken(User user) {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new[] { new Claim(ClaimTypes.Role, user.Role), new Claim(ClaimTypes.Email, user.Email), new Claim("id", user.Id.ToString()) };
        var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddHours(2), signingCredentials: creds);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
public class EmailService { public Task SendAsync(string to, string s, string b) { return Task.CompletedTask; } }
