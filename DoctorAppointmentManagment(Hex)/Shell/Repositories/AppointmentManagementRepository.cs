using AutoMapper;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment_Hex_.Shell.Repositories;

public class AppointmentManagementRepository : IAppointmentManagementRepositoryPort
{
    private IAppointmentBookingModule appointmentBookingModule;
    private IMapper mapper;
    
    public AppointmentManagementRepository(IAppointmentBookingModule appointmentBookingModule, IMapper mapper)
    {
        this.appointmentBookingModule = appointmentBookingModule;
        this.mapper = mapper;
    }
    
    public async Task<IEnumerable<UpcommingAppointment>> GetUpcomingAppointments(Guid doctorId)
    {
        var appointments=await  appointmentBookingModule.GetUpcomingAppointmentsForDoctor(doctorId);

        return appointments.Select(mapper.Map<UpcommingAppointment>);
    }
    
    
   
    public  Task<bool> IsAppointmentExists(Guid appointmentId)
    {   
        return appointmentBookingModule.IsAppointmentExists(appointmentId);

    }

    public Task ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status)
    {
        return appointmentBookingModule.ChangeAppointmentStatus(appointmentId, status);
        
    }

   
    
}