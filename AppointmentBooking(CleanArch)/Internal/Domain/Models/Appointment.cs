using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;

public class Appointment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    
    public Guid DoctorId { get; set; }
    public string? PatientName { get; set; }
    public DateTime ReservedAt { get; set ;} = DateTime.Now;
    
    public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
    
}