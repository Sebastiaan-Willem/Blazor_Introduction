using Blazor_Introduction.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Introduction
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            /*
             
             dotnet watch run --project <project name>

            to put watcher on the project and "hot reload" changes to frontend without having to rebuild for every single change
             
             
             */

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddSingleton<IGenreService, GenreService>();

            await builder.Build().RunAsync();
        }
    }
}
