using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;

namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain;

public class  BookSlotUseCase
{
    private IAppointmentBookingService appointmentBookingService;

    public BookSlotUseCase(IAppointmentBookingService appointmentBookingService)
    {
        this.appointmentBookingService = appointmentBookingService;
    }

    public Task Execute(Guid slotId, Guid patientId)
    {
        return appointmentBookingService.BookSlot(slotId, patientId);
    }
}