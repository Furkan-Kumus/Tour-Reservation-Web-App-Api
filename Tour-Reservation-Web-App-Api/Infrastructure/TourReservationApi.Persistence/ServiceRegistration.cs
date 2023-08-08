using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.PowerBI.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Abstractions;
using TourReservationApi.Application.Abstractions.Token;
using TourReservationApi.Application.Repositories;
using TourReservationApi.Domain.Entities.Identity;
using TourReservationApi.Infrastructure.Services.Token;
using TourReservationApi.Persistence.Concretes;
using TourReservationApi.Persistence.Contexts;
using TourReservationApi.Persistence.Repositories;
using TourReservationApi.Application.Repositories;
using TourReservationApi.Persistence.Repositories;
using TourReservationApi.Domain.Entities.Identity;

namespace TourReservationApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddTransient<ITokenHandler, TokenHandler>();  //ben+

            services.AddDbContext<RegisterAPIDbContext>(options => options.UseNpgsql("Host=localhost; Database=TourReservationDb; Username=postgres; Password=123; Port=5432"));
            services.AddIdentity<Domain.Entities.Identity.AppUser, AppRole>(
            ).AddEntityFrameworkStores<RegisterAPIDbContext>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IRegionReadRepository, RegionReadRepository>();
            services.AddScoped<IRegionWriteRepository, RegionWriteRepository>();
            services.AddScoped<ICountryReadRepository, CountryReadRepository>();
            services.AddScoped<ICountryWriteRepository, CountryWriteRepository>();
            services.AddScoped<IAirportReadRepository, AirportReadRepository>();
            services.AddScoped<IAirportWriteRepository, AirportWriteRepository>();
            services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
            services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();
            services.AddScoped<ICityReadRepository, CityReadRepository>();
            services.AddScoped<ICityWriteRepository, CityWriteRepository>();
            services.AddScoped<IDriverReadRepository, DriverReadRepository>();
            services.AddScoped<IDriverWriteRepository, DriverWriteRepository>();
        }
    }
}
