using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
// Allow local storage
using Blazored.LocalStorage;

namespace DecisionMaker
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // !! ---Register activity to share between pages----- !!
            builder.Services.AddSingleton<Activity>();
            
            // Add local storage
            builder.Services.AddBlazoredLocalStorage(); 
            await builder.Build().RunAsync();


           

        }
    }
}
