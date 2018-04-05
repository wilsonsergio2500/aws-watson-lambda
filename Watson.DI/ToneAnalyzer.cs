using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Watson.Models;

namespace Watson.DI
{
    public class ToneAnalyzer
    {
        private static IServiceProvider serviceProvider { get; set; }
        public static IServiceProvider DIServiceProvider { get { return serviceProvider; } }

        public ToneAnalyzer()
        {
            Inject();
        }

        private void Inject() {

            IServiceCollection services = new ServiceCollection();
            services.AddOptions();

            Action<ToneAnalyzerConfig> IOptionTokenAnalyzer = (ToneAnalyzerConfig config) => {
                config.username = Environment.GetEnvironmentVariable("username");
                config.password = Environment.GetEnvironmentVariable("password");
                config.version = Environment.GetEnvironmentVariable("version");
            };

            services.Configure<ToneAnalyzerConfig>(IOptionTokenAnalyzer);
            services.AddSingleton<Interfaces.Services.IToneAnalyzer, Worker.Services.ToneAnalyzer>();
            services.AddSingleton<Interfaces.Functions.IFuncToneAnalyzer, Worker.Functions.FuncToneAnalyzer>();
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
