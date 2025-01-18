namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;

public record AppointmentDto{
       
    public Guid PatientId { get; init; }
    public Guid DoctorId { get; init; }
    public string PatientName { get; init; }
    public DateTime AppointmentTime { get; init; }
    public string DoctorName { get; init; }
}
    
    
