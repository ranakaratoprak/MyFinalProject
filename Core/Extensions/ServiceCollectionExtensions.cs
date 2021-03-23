﻿using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules) // genişletmek istediğin yerler bu parantez içerisinde yazılır
        {
            foreach (var modul in modules)
            {
                modul.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }
    }
}
