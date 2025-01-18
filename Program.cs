using AutoMapper;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentBooking_CleanArch_.Domain.Repository;
using Doctor_Appointment_Booking_Course_Assessment.AppointmentConfirmation;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Data.Repositories;
using Doctor_Appointment_Booking_Course_Assessment.DoctorAvailability_Layred_.Domain.Services;
using Doctor_Appointment_Booking_Course_Assessment.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddScoped<DoctorService>();
builder.Services.AddScoped<GetAvailableDoctorSlotsUseCase>();
builder.Services.AddScoped<BookSlotUseCase>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IDoctorAvailabilityModule, DoctorAvailabilityModule>();
builder.Services.AddScoped<IAppointmentBookingService, AppointmentBookingService>();
builder.Services.AddScoped<IAppointmentConfirmation, AppointmentConfirmation>();
builder.Services.AddScoped<INotificationService, NotificationService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
config.AssertConfigurationIsValid();


builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();