using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Repository;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Data.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    
    private List<Appointment> appointments = new List<Appointment>();
    public async Task AddAppointment(Appointment appointment)
    {
        appointments.Add(appointment);
    }
}