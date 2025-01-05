
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;
using Microsoft.AspNetCore.Mvc;
namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Api;


[ApiController]  // Enables automatic model validation
[Route("api/[controller]")]
public class DoctorSlotsController : ControllerBase
{
    [HttpGet("[action]/{doctorId}")]  // GET /api/DoctorSlots/123
    [ProducesResponseType(StatusCodes.Status200OK)]  // Documents 200 OK response
    [ProducesResponseType(StatusCodes.Status404NotFound)]  // Documents 404 Not Found response
    public async Task<ActionResult<IEnumerable<DoctorSlot>>> GetDoctorSlots(Guid doctorId)
    {
        var doctorService = new DoctorService();
        
        var slots = (await doctorService.GetDoctorSlots(doctorId)).ToList();
    
        if (!slots.Any())
            return NotFound($"No available slots found for doctor with ID: {doctorId}");

        return Ok(slots);
    }


    [HttpPost("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DoctorSlot>> AddNewSlot([FromBody] DoctorSlot slot)
    {
        var doctorService = new DoctorService();
        try
        {
            await doctorService.AddNewSlot(slot);
            return Ok(slot);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        
    }
}