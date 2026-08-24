using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase {
    private readonly ClinicContext _context;
    public DoctorsController(ClinicContext context) => _context = context;
    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.Doctors.ToListAsync());
    [HttpPost] public async Task<IActionResult> Add(Doctor d) { _context.Doctors.Add(d); await _context.SaveChangesAsync(); return Ok(d); }
}
