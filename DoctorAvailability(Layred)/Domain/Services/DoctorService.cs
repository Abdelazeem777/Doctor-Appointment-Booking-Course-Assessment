using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Data.Repositories;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;

public class DoctorService
{
    public Task<IEnumerable<DoctorSlot>> GetDoctorSlots(Guid doctorId)
    {
        var repository = new DoctorSlotsRepository();
        return repository.GetDoctorSlots(doctorId);
    }

    public async Task AddNewSlot(DoctorSlot slot)
    {
        var repository = new DoctorSlotsRepository();
        var isSlotAvailable = await repository.IsSlotAvailable(slot.DoctorId, slot.Time);
        
        if (!isSlotAvailable)
            throw new Exception("Slot is not available");

        await repository.AddNewSlot(slot);
    }
}