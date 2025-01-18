using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_;

public interface IDoctorAvailabilityModule
{
    public Task<IEnumerable<DoctorSlot>> GetAvailableDoctorSlots();

    public Task<bool> IsSlotAvailable(Guid slotId);
    
    public Task BookSlot(Guid slotId);
}