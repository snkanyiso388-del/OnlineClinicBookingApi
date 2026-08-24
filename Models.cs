public class Doctor { public int Id { get; set; } public string Name { get; set; } = ""; public string Specialty { get; set; } = ""; public string Email { get; set; } = ""; }
public class Patient { public int Id { get; set; } public string FullName { get; set; } = ""; public string Email { get; set; } = ""; public string Phone { get; set; } = ""; }
public enum AppointmentStatus { Pending, Confirmed, Cancelled }
public class Appointment { public int Id { get; set; } public int DoctorId { get; set; } public int PatientId { get; set; } public DateTime StartTime { get; set; } public DateTime EndTime { get; set; } public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending; public string Reason { get; set; } = ""; }
public class User { public int Id { get; set; } public string Email { get; set; } = ""; public string PasswordHash { get; set; } = ""; public string Role { get; set; } = "Patient"; }
public record BookAppointmentDto(int DoctorId, int PatientId, DateTime StartTime, string Reason);
public record LoginDto(string Email, string Password);
