
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch.Api;


[ApiController]  // Enables automatic model validation
[Route("api/[controller]")]
public class AppointmentBookingController : ControllerBase
{
    
    private GetAvailableDoctorSlotsUseCase getAvaialbleDoctorSlotsUseCase;
    private BookSlotUseCase bookSlotUseCase;
    
    public AppointmentBookingController(GetAvailableDoctorSlotsUseCase getAvaialbleDoctorSlotsUseCase, BookSlotUseCase bookSlotUseCase)
    {
        this.getAvaialbleDoctorSlotsUseCase = getAvaialbleDoctorSlotsUseCase;
        this.bookSlotUseCase = bookSlotUseCase;
    }

    
    [HttpGet("[action]")]  // GET /api/GetAvailableDoctorSlots
    [ProducesResponseType(StatusCodes.Status200OK)]  // Documents 200 OK response
    [ProducesResponseType(StatusCodes.Status404NotFound)]  // Documents 404 Not Found response
    public async Task<ActionResult<IEnumerable<DoctorSlot>>> GetAvailableDoctorSlots()
    {
        var slots = (await getAvaialbleDoctorSlotsUseCase.Execute()).ToList();
        
        if (!slots.Any())
            return NotFound($"No available slots found");
        
        return Ok(slots);
    }
    
    
    [HttpPost("[action]")]  // POST /api/BookSlot
    [ProducesResponseType(StatusCodes.Status200OK)]  // Documents 200 OK response
    [ProducesResponseType(StatusCodes.Status404NotFound)]  // Documents 404 Not Found response
    public async Task<ActionResult> BookSlot(Guid slotId, Guid patientId)
    {
        try
        {
            await bookSlotUseCase.Execute(slotId, patientId);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    


    
}