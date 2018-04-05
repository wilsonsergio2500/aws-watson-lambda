using Microsoft.Extensions.DependencyInjection;
using System;
using Watson.Models;

namespace Watson.DI
{
    public class PersonalInsights
    {

        private static IServiceProvider serviceProvider { get; set; }
        public static IServiceProvider DIServiceProvider { get { return serviceProvider; } }

        public PersonalInsights()
        {
            Inject();
        }

        private void Inject()
        {

            IServiceCollection services = new ServiceCollection();
            services.AddOptions();

            Action<PersonalityInsightsConfig> IOptionPersonalInsight = (PersonalityInsightsConfig config) => {
                config.username = Environment.GetEnvironmentVariable("username");
                config.password = Environment.GetEnvironmentVariable("password");
                config.version = Environment.GetEnvironmentVariable("version");
            };

            services.Configure<PersonalityInsightsConfig>(IOptionPersonalInsight);
            services.AddSingleton<Interfaces.Services.IPersonalityInsights, Worker.Services.PersonalityInsights>();
            services.AddSingleton<Interfaces.Functions.IFuncPersonalityInsights, Worker.Functions.FuncPersonalityInsights>();
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
