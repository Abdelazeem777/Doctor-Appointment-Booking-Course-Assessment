var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// For testing purposes, setting the current time to: 2025-01-03 19:59:36
// And current user: Abdelazeem777

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();