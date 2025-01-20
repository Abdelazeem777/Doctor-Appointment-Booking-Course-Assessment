using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Repository;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_;

public class AppointmentBookingModule : IAppointmentBookingModule
{
    
    private IAppointmentRepository appointmentRepository;
    
    public AppointmentBookingModule(IAppointmentRepository appointmentRepository)
    {
        this.appointmentRepository = appointmentRepository;
    }
    
    public Task<IEnumerable<Appointment>> GetUpcomingAppointmentsForDoctor(Guid doctorId)
    {
        return appointmentRepository.GetUpcomingAppointmentsForDoctor(doctorId);
    }
    
    public Task<bool> IsAppointmentExists(Guid appointmentId)
    {
        return appointmentRepository.IsAppointmentExists(appointmentId);
    }
    
    public Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status)
    {
        return appointmentRepository.ChangeAppointmentStatus(appointmentId, status);
    }
}