using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core;

public interface IAppointmentManagementRepositoryPort
{
    Task<bool> IsAppointmentExists(Guid appointmentId);

    Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status);


    Task<IEnumerable<UpcommingAppointment>> GetUpcomingAppointments(Guid doctorId);
}