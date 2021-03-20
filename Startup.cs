using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarGallery.Models;
using CarGallery.Repository;
using CarGallery.Repository.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CarGallery
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();

            services.AddDbContext<AppDbContext>(options =>
                    options.UseInMemoryDatabase($"car-gallery-db"));


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            AddData(app);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });



        }

        private void AddData(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<AppDbContext>();

            if (context.Cars.Count() == 0)
            {
                context.Cars.Add(new Car
                {
                    CarId = Guid.NewGuid(),
                    Name = "Porsche 911 Turbo",
                    ShortDescription = "Porsche 911 Turbo S",
                    LongDescription = "Sempre que um carro apresenta um comportamento irrepreensível, é difícil não nos perguntarmos como será possível fazer algo melhor em uma futura geração. Desde a primeira edição do 911 Turbo, em 1975, porém, os engenheiros da Porsche vêm conseguindo essa insuspeita superação e desta vez não foi diferente.",
                    ImageUrl = "/images/porsche/porsche_911_Turbo.jpg",
                    ImageThumbnailUrl = "/images/porsche/porsche_911_Turbo_small.jpg",
                    CategoryName = "Porsche"
                });

                context.Cars.Add(new Car
                {
                    CarId = Guid.NewGuid(),
                    Name = "Porsche Cayenne",
                    ShortDescription = "O equilibrio entre desempenho e conforto",
                    LongDescription = "Cayenne é um case de sucesso na indústria automobilística. Graças a ele, a Porsche se reinventou, passou a ganhar dinheiro como nunca e hoje é ainda mais forte do que era quando se fala em automóveis esportivos. Com mais de 800 mil unidades vendidas no mundo e 5,2 mil no Brasil, o Cayenne se dá ao luxo de cobrar a mais pelo logotipo que carrega",
                    ImageUrl = "/images/porsche/porsche-cayenne-coupe.jpg",
                    ImageThumbnailUrl = "/images/porsche/porsche-cayenne-coupe_small.jpg",
                    CategoryName = "Porsche"
                });

                context.Cars.Add(new Car
                {
                    CarId = Guid.NewGuid(),
                    Name = "Ferrari F8 Tributo",
                    ShortDescription = "F8 Tributo - A lenda",
                    LongDescription = "F8 Tributo é uma homenagem ao premiado motor V8 da marca italiana. Trata-se de um 3.9 biturbo, que entrega 720 cavalos e 78,5 kgfm de torque",
                    ImageUrl = "/images/ferrari/ferrari-F8.jpg",
                    ImageThumbnailUrl = "/images/ferrari/ferrari-F8_small.jpg",
                    CategoryName = "Ferrari"
                });

                context.Cars.Add(new Car
                {
                    CarId = Guid.NewGuid(),
                    Name = "Ferrari 458 Spider",
                    ShortDescription = "O V8 mais poderoso já feito pela marca",
                    LongDescription = "O coração do novo 458 Spider é o vencedor do Prêmio Motor Internacional do Ano de 2018, um V8 twin-turbo de 3,9 litros com 720 cavalos de potência e 78,52 kgfm de torque",
                    ImageUrl = "/images/ferrari/ferrarri_spider.jpg",
                    ImageThumbnailUrl = "/images/ferrari/ferrarri_spider_small.jpg",
                    CategoryName = "Ferrari"
                });

                context.Cars.Add(new Car
                {
                    CarId = Guid.NewGuid(),
                    Name = "Ford Mustang",
                    ShortDescription = "O melhor pony car",
                    LongDescription = "O Mustang GT é absolutamente a melhor forma de começar o dia, já que seu motor é uma joia. O V8 ainda mantém o nome de Coyote, mas não é quieto como o anterior. O motor esbraveja como o melhor muscle car de todos os tempos.",
                    ImageUrl = "/images/ford/ford_mustang.jpg",
                    ImageThumbnailUrl = "/images/ford/ford_mustang_small.jpg",
                    CategoryName = "Ford"
                });

                context.SaveChanges();
            }

        }
    }
}
