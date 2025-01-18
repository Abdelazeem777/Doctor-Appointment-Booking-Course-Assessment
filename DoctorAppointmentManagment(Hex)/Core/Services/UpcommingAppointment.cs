using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

public record UpcommingAppointment
{
    public Guid AppointmentId { get; init; }
    public Guid PatientId { get; init; }
    public string? PatientName { get; init; }
    public Guid DoctorId { get; init; }
    public DateTime AppointmentDate { get; init; }
    public AppointmentStatus Status { get; init; }
    
}