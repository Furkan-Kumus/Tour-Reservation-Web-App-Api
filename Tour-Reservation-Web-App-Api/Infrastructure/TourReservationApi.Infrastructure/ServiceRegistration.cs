using TourReservationApi.Application.Abstractions.Token;
using TourReservationApi.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace TourReservationApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();

        }
        
    }
}
