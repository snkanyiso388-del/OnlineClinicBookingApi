using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase {
    private readonly ClinicContext _context; private readonly AuthService _auth;
    public AuthController(ClinicContext context, AuthService auth) { _context = context; _auth = auth; }
    [HttpPost("register")] public async Task<IActionResult> Register(User user) { user.PasswordHash = _auth.Hash(user.PasswordHash); _context.Users.Add(user); await _context.SaveChangesAsync(); return Ok(user); }
    [HttpPost("login")] public async Task<IActionResult> Login(LoginDto dto) { var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email); if(user==null ||!_auth.Verify(dto.Password, user.PasswordHash)) return Unauthorized(); return Ok(new { token = _auth.GenerateToken(user) }); }
}
