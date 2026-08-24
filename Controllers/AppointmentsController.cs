using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase {
    private readonly ClinicContext _context;
    public AppointmentsController(ClinicContext context) => _context = context;
    [HttpPost("book")]
    public async Task<IActionResult> Book(BookAppointmentDto dto) {
        var exists = await _context.Appointments.AnyAsync(a => a.DoctorId == dto.DoctorId && a.StartTime == dto.StartTime);
        if(exists) return BadRequest("Doctor not available");
        var appt = new Appointment { DoctorId = dto.DoctorId, PatientId = dto.PatientId, StartTime = dto.StartTime, EndTime = dto.StartTime.AddMinutes(30), Reason = dto.Reason };
        _context.Appointments.Add(appt); await _context.SaveChangesAsync(); return Ok(appt);
    }
    [HttpGet] public async Task<IActionResult> GetAll() => Ok(await _context.Appointments.ToListAsync());
}
