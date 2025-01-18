namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;

public interface INotificationService
{
    
    public Task Notify(List<Guid> users, string message);
}