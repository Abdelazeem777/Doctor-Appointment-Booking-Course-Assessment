namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;


public class DoctorSlot
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public Guid DoctorId { get; set; }
    public string DoctorName { get; set; }
    public bool IsReserved { get; set; }
    public decimal Cost { get; set; }   
    
}