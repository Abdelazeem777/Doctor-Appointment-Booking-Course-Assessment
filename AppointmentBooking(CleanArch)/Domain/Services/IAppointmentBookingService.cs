using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Data.Repositories;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;

public interface IAppointmentBookingService
{
    public Task<IEnumerable<DoctorSlot>> GetAvailableDoctorSlots();
    public Task BookSlot(Guid slotId, Guid patientId);
}