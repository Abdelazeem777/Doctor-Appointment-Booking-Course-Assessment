using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.InputPorts;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

public class DoctorAppointmentManagement : DoctorAppointmentManagementPort
{
    private readonly IAppointmentManagementRepositoryPort _appointmentManagementRepository;
    
    public DoctorAppointmentManagement(IAppointmentManagementRepositoryPort appointmentManagementRepository)
    {
        _appointmentManagementRepository = appointmentManagementRepository;
    }
    public async Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status)
    {
        var isExist = await _appointmentManagementRepository.IsAppointmentExists(appointmentId);
        
        if (isExist == null)
            throw new Exception("Appointment not found");
        
        await _appointmentManagementRepository.ChangeAppointmentStatus(appointmentId, status);

    }

    public Task<IEnumerable<UpcommingAppointment>> GetUpcomingAppointments(Guid doctorId)
    {
        return _appointmentManagementRepository.GetUpcomingAppointments(doctorId);
    }
    
}