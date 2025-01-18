using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.InputPorts;

public interface DoctorAppointmentManagementPort
{
    Task<IEnumerable<UpcommingAppointment>> GetUpcomingAppointments(Guid doctorId);
    Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status);
    
}