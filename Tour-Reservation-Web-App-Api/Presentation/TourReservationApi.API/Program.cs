using ETicaretAPI.Application;
using TourReservationApi.Persistence;
using TourReservationApi.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistanceServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
