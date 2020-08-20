﻿using System;
using Microsoft.Extensions.Configuration;

namespace SampleFunctionsApp
{
    internal static class ConfigurationHelper
    {
        public static AdtConfiguration GetAdtConfiguration()
        {
            var config = new AdtConfiguration();
            var Configuration = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("local.settings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
            Configuration.GetSection(nameof(AdtConfiguration)).Bind(config);

            return config;
        }
    }
}
