using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Data.Repositories;

public class DoctorSlotsRepository
{
    private static readonly List<DoctorSlot> _slots = new()
    {
        new DoctorSlot
        {
            Id = Guid.NewGuid(),
            Time = DateTime.Parse("2025-01-03 20:30:00Z"),
            DoctorId = Guid.Parse("12345678-1234-1234-1234-123456789012"),
            DoctorName = "Dr. John Smith",
            IsReserved = false,
            Cost = 150.00m
        },
        new DoctorSlot
        {
            Id = Guid.NewGuid(),
            Time = DateTime.Parse("2025-01-03 21:00:00Z"),
            DoctorId = Guid.Parse("12345678-1234-1234-1234-123456789012"),
            DoctorName = "Dr. John Smith",
            IsReserved = false,
            Cost = 150.00m
        },

        new DoctorSlot
        {
            Id = Guid.NewGuid(),
            Time = DateTime.Parse("2025-01-03 21:30:00Z"),
            DoctorId = Guid.Parse("12345678-1234-1234-1234-123456789012"),
            DoctorName = "Dr. John Smith",
            IsReserved = true,
            Cost = 150.00m
        }
    };
    
    
    public async Task<IEnumerable<DoctorSlot>> GetDoctorSlots(Guid doctorId)
    {   

        return _slots.Where(s => s.DoctorId == doctorId);
    }
    
    public async Task AddNewSlot(DoctorSlot slot)
    {

        _slots.Add(slot);
    }

    public async Task<bool> IsSlotAvailable(Guid slotDoctorId, DateTime slotTime)
    {
    
        return !_slots.Any(s => s.DoctorId == slotDoctorId && s.Time == slotTime);
    }
    
    public async Task<bool> IsSlotAvailable(Guid slotId)
    {
        return _slots.Any(s => s.Id == slotId && !s.IsReserved);
    }
    
    public async Task<IEnumerable<DoctorSlot>> GetAvailableSlots()
    {
        return _slots.Where(s => !s.IsReserved);
    }
    
    public async Task BookSlot(Guid slotId)
    {
        var slot = _slots.FirstOrDefault(s => s.Id == slotId);
        if (slot == null)
            throw new Exception("Slot not found");
        if (slot.IsReserved)
            throw new Exception("Slot is already reserved");
        slot.IsReserved = true;
    }

    public async Task<DoctorSlot?> GetSlotIfExists(Guid slotId)
    {
        return  _slots.FirstOrDefault(s => s.Id == slotId);
    }

    public async Task FreeSlot(Guid slotId)
    {
        var slot = _slots.FirstOrDefault(s => s.Id == slotId);
        if (slot == null)
            throw new Exception("Slot not found");
        if (!slot.IsReserved)
            throw new Exception("Slot is already free");
        slot.IsReserved = false;
    }
}