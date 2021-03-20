using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using CarGallery;
using System.IO;

namespace Selenium
{
    public class WebHost
    {
        public IHost host;
        public Boolean hostIsRunning = false;
        public string URL = "http://localhost:{0}";


        public Task StartServer()
        {
            URL = String.Format(URL, new Random().Next(5000, 5100));

            host = CreateHostBuilder().Build();
            host.RunAsync();

            System.Threading.Thread.Sleep(1500);

            return Task.CompletedTask;
        }

        public IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                              .UseContentRoot("/home/runner/work/cargallery/cargallery")
                              .UseUrls(URL);
                });
    }
}
