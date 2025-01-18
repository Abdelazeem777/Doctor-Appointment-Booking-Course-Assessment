namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;

public interface IAppointmentConfirmation
{
    public Task Notify(AppointmentDto appointment);
}