using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Repository;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Data.Repositories;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;

public class AppointmentBookingService : IAppointmentBookingService
{
    private IDoctorAvailabilityModule doctorAvailabilityModule;
    private IAppointmentRepository appointmentRepository;
    
    public AppointmentBookingService(IDoctorAvailabilityModule doctorAvailabilityModule, IAppointmentRepository appointmentRepository)
    {
        this.doctorAvailabilityModule = doctorAvailabilityModule;
        this.appointmentRepository = appointmentRepository;
    }
    public Task<IEnumerable<DoctorSlot>> GetAvailableDoctorSlots()
    {
        return doctorAvailabilityModule.GetAvailableDoctorSlots();
    }

    public async Task BookSlot(Guid slotId, Guid patientId)
    {
        var isSlotAvailable = await doctorAvailabilityModule.IsSlotAvailable(slotId);
        if(!isSlotAvailable) throw new Exception("Slot is not available");
        
        await doctorAvailabilityModule.BookSlot(slotId);
        
        await appointmentRepository.AddAppointment(new Appointment
        {
            SlotId  = slotId,
            //TODO: Get patient name from patientId!
            PatientName = "Patient",
            PatientId = patientId
        });
        
        
    }
}