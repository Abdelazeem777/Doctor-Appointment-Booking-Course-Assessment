using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Repository;

public interface IAppointmentRepository
{
    Task AddAppointment(Appointment appointment);
    
}