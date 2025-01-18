namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;

public class AppointmentConfirmation : IAppointmentConfirmation
{
    
    private readonly INotificationService notificationService;
    
    public AppointmentConfirmation(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    
    public Task Notify(AppointmentDto appointment)
    {
        var users = new List<Guid>(){ appointment.PatientId, appointment.DoctorId };
        var message = "Patient: " + appointment.PatientName + " Appointment Time: " + appointment.AppointmentTime + " Doctor: " + appointment.DoctorName;
        
        return notificationService.Notify(users,message);
    }
    
}