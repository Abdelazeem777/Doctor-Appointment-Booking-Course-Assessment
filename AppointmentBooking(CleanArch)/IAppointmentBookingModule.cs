using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_;

public interface IAppointmentBookingModule
{
    
    public Task<IEnumerable<Appointment>> GetUpcomingAppointmentsForDoctor(Guid doctorId);
    
    public Task<bool> IsAppointmentExists(Guid appointmentId);
    
    public Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status);
}