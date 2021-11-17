using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using XebecPortal.Client.GamifiedEnvBeta.Utils;
using XebecPortal.Client.JobPortalTestEnv.New_Job_Board;
using Microsoft.Extensions.DependencyInjection.Extensions;
using XebecPortal.Client.JobPortalTestEnv;

namespace XebecPortal.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<State>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<NotifierService>();


            builder.Services.AddScoped<IPersonalInformationDataService, PersonalInformationDataService>();
            builder.Services.AddScoped<IApplicationPhaseDataService, ApplicationPhaseDataService>();
            builder.Services.AddScoped<IApplicationPhaseHelperDataService, ApplicationPhaseHelperDataService>();
            builder.Services.AddScoped<IStatusDataService, StatusDataService>();
            builder.Services.AddScoped<IJobDataService, JobDataService>();
            await builder.Build().RunAsync();
        }
    }
}
