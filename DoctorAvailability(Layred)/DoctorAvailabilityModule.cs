using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_;

public class DoctorAvailabilityModule : IDoctorAvailabilityModule
{
    private DoctorService doctorService;
    public DoctorAvailabilityModule(DoctorService doctorService)
    {
        this.doctorService = doctorService;
    }

    public Task<IEnumerable<DoctorSlot>> GetAvailableDoctorSlots(){
        
        return doctorService.GetAvailableDoctorSlots();
    }
    
    public Task<DoctorSlot?> GetSlotIfExists(Guid slotId)
    {
        return doctorService.GetSlotIfExists(slotId);
    }
    
    
    public Task BookSlot(Guid slotId)
    {
        return doctorService.BookSlot(slotId);
    }
    
    public Task FreeSlot(Guid slotId)
    {
        return doctorService.FreeSlot(slotId); 
    }

}