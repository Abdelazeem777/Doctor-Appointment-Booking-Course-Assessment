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

    public Task<IEnumerable<DoctorSlot>> GetAvailableDoctorSlots()
    {
        var repository = new DoctorSlotsRepository();
        return repository.GetAvailableSlots();
    }
    
    public Task<bool> IsSlotAvailable(Guid slotId)
    {
        var repository = new DoctorSlotsRepository();
        return repository.IsSlotAvailable(slotId);
    }
    
    
    public Task<DoctorSlot?> GetSlotIfExists(Guid slotId)
    {
        var repository = new DoctorSlotsRepository();
        return repository.GetSlotIfExists(slotId);
    }
    
    public Task BookSlot(Guid slotId)
    {
        var repository = new DoctorSlotsRepository();
        return repository.BookSlot(slotId);
    }

    public Task FreeSlot(Guid slotId)
    {
        var repository = new DoctorSlotsRepository();
        return repository.FreeSlot(slotId);
    }
}