using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.InputPorts;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Shell;


[ApiController] // Enables automatic model validation
[Route("api/[controller]")] // Defines the route for the controller
public class DoctorAppointmentManagement : ControllerBase
{
    private readonly DoctorAppointmentManagementPort _doctorAppointmentManagementPort;

    public DoctorAppointmentManagement(DoctorAppointmentManagementPort doctorAppointmentManagementPort)
    {
        _doctorAppointmentManagementPort = doctorAppointmentManagementPort;
    }

    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Documents 200 OK response
    [ProducesResponseType(StatusCodes.Status404NotFound)] // Documents 404 Not Found response
    public async Task<IActionResult> GetUpcomingAppointments(Guid doctorId)
    {
        try
        {
            var upcomingAppointments = await _doctorAppointmentManagementPort.GetUpcomingAppointments(doctorId);
            return Ok(upcomingAppointments);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }

    }

    
    [HttpPost("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Documents 200 OK response
    [ProducesResponseType(StatusCodes.Status404NotFound)] // Documents 404 Not Found response
    public async Task<IActionResult> ChangeAppointmentStatus(Guid appointmentId, AppointmentStatus status)
    {
        if( status != AppointmentStatus.Completed && status != AppointmentStatus.Cancelled)
            return BadRequest("Invalid status");
        
        try
        {
            await _doctorAppointmentManagementPort.ChangeAppointmentStatus(appointmentId, status);
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
}