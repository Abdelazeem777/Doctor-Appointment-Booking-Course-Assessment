using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Repository;

public interface IAppointmentRepository
{
    public Task AddAppointment(Appointment appointment);
    public Task<IEnumerable<Appointment>> GetUpcomingAppointmentsForDoctor(Guid doctorId);

    Task<bool> IsAppointmentExists(Guid appointmentId);
    Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status);
}