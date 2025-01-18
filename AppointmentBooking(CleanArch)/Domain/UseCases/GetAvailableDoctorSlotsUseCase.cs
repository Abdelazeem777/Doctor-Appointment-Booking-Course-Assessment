using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain;

public class GetAvailableDoctorSlotsUseCase
{
    private IAppointmentBookingService appointmentBookingService;

    public GetAvailableDoctorSlotsUseCase(IAppointmentBookingService appointmentBookingService)
    {
        this.appointmentBookingService = appointmentBookingService;
    }

    public Task<IEnumerable<DoctorSlot>> Execute()
    {
        return appointmentBookingService.GetAvailableDoctorSlots();
    }
}