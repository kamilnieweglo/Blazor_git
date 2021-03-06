﻿/*! Copyright © 2021 Rick Beerendonk !*/

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Lab_Components
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            await builder.Build().RunAsync();
        }
    }
}
