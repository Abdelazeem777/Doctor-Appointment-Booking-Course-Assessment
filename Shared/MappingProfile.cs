using AutoMapper;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;

namespace Doctor_Appointment_Booking_Course_Assessment.Shared;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        // Map from Appointment to AppointmentDto
        CreateMap<Appointment, AppointmentDto>()
            .ForMember(dest => dest.AppointmentTime, opt => opt.MapFrom(src => src.ReservedAt))
            .ForMember(dest => dest.DoctorId, opt => opt.Ignore())
            .ForMember(dest => dest.DoctorName, opt => opt.Ignore());

    }
}