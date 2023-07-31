using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.PowerBI.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Abstractions;
using TourReservationApi.Domain.Entities.Identity;
using TourReservationApi.Persistence.Concretes;
using TourReservationApi.Persistence.Contexts;

namespace TourReservationApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<RegisterAPIDbContext>(options => options.UseNpgsql("Host=localhost; Database=TourReservationDb; Username=postgres; Password=123; Port=5432"));
            services.AddIdentity<Domain.Entities.Identity.AppUser, AppRole>(
            ).AddEntityFrameworkStores<RegisterAPIDbContext>();
        }
    }
}
