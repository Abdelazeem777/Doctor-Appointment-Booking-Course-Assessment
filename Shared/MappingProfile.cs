using AutoMapper;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Models;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAppointmentManagment.Core.Services;

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

        CreateMap<Appointment, UpcommingAppointment>()
            .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.ReservedAt))
            .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.DoctorId))
            .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.PatientId))
            .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.PatientName))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
    }
}