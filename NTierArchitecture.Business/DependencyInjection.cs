﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business;
public static class DependencyInjection
{
    public static IServiceCollection AddBusiness(
        this IServiceCollection services)
    {
        return services;
    }
}
