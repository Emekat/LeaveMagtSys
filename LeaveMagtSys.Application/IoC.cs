﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeaveMagtSys.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
             services.AddAutoMapper(Assembly.GetExecutingAssembly());
             services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            return services;

        }
    }
}
