using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Infrastructure;
using BLL.Infrastructure.Provider;
using BLL.Service;
using BLL.Service.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MVC_IDENTITY_EXAMPLE_UI_.Infrastructure;

namespace MVC_IDENTITY_EXAMPLE_UI_
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

            services.AddTransient(typeof(CarService));



            services.AddControllersWithViews();

            BllConfiguration.Configuration(services, Configuration.GetConnectionString("defCon"));

            var option = new SendGridOptions();
            Configuration.GetSection("SendGridOptions").Bind(option);
            services.AddTransient<SendGridOptions>(x=> option);
            //services.AddTransient(typeof(SendGridOptions));
            
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<EmailConfirmationProviderOption>(op => op.TokenLifespan = TimeSpan.FromHours(2));

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperConfig());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddAuthentication().AddCookie(op => op.LoginPath = "/Login");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
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
            }
            app.UseStaticFiles();

            app.UseRouting();

         app.UseAuthentication();   //1
         app.UseAuthorization();   //2 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
