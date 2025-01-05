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
    
    public Task AddNewSlot(DoctorSlot slot)
    {
        var repository = new DoctorSlotsRepository();
        return repository.AddNewSlot(slot);
    }
}