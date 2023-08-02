using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using TourReservationApi.Application;
using TourReservationApi.Persistence;
using TourReservationApi.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistanceServices();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Admin", options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, //Olu�turulacak token de�erini kimlerin/hangi originlerin/sitelerin kullan�c� belirledi�imiz de�erdir. -> www.bilmemne.com
            ValidateIssuer = true, //Olu�turulacak token de�erini kimin da��tt�n� ifade edece�imiz aland�r. -> www.myapi.com
            ValidateLifetime = true, //Olu�turulan token de�erinin s�resini kontrol edecek olan do�rulamad�r.
            ValidateIssuerSigningKey = true, //�retilecek token de�erinin uygulamam�za ait bir de�er oldu�unu ifade eden suciry key verisinin do�rulanmas�d�r.

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
            };
    });
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();


builder.Services.AddCors(options =>
     options.AddDefaultPolicy(builder =>
     builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
