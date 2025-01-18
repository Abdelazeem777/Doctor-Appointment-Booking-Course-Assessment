using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment_Hex_.Shell.Repositories;

public class AppointmentManagementRepository : IAppointmentManagementRepositoryPort
{
    public Task<bool> IsAppointmentExists(Guid appointmentId)
    {
        throw new NotImplementedException();
    }

    public Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UpcommingAppointment>> GetUpcomingAppointments(Guid doctorId)
    {
        throw new NotImplementedException();
    }
    
}