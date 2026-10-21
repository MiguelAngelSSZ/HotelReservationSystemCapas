using Microsoft.Extensions.DependencyInjection;
using HotelReservationSystem.BL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.BL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<IHotelService, HotelService>();

                        //    services.AddScoped<IReservaService, ReservaService>();
            
            return services;
        }
    }
}