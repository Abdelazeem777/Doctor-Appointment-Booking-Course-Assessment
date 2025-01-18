namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;

public class NotificationService : INotificationService
{
    public async Task Notify(List<Guid> users, string message)
    {
        
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine("User: " + users[i] + " Message: " + message);
        }
    }
    
}