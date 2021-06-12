using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Logging;
using Swashbuckle;

namespace HolisticWare.Ph4ct3x.Server
{
    public partial class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        //  https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup
        //  https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments    
        public void ConfigureProductionServices(IServiceCollection services)
        {
            services.AddLogging
                        (
                            loggingBuilder =>
                            {
                                //loggingBuilder.AddConfiguration(Configuration.GetSection("Logging"));
                                //loggingBuilder.AddConsole();
                                //loggingBuilder.AddDebug();
                                //loggingBuilder.AddTraceSource();

                                return;
                            }
                        );
            
            // export   ASPNETCORE_HTTPS_PORT=443
            // set      ASPNETCORE_HTTPS_PORT=443
            services.AddHttpsRedirection(options => options.HttpsPort = options.HttpsPort + 1);

            services.Configure<CookiePolicyOptions>
            (
                options =>
                {
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
                }
            );

            // The Tempdata provider cookie is not essential. Make it essential
            // so Tempdata is functional when tracking is disabled.
            services.Configure<CookieTempDataProviderOptions>
            (
                options =>
                {
                    options.Cookie.IsEssential = true;
                }
            );
           
             services.AddDistributedMemoryCache();

            services.AddSession
            (
                options =>
                {
                    // Set a short timeout for easy testing.
                    options.IdleTimeout = TimeSpan.FromSeconds(10);
                    options.Cookie.HttpOnly = true;
                }
            );

            //services.AddDbContext<StorageContext>
            //(
            //    options =>
            //    {
            //        options.UseInMemoryDatabase(Guid.NewGuid());
            //    }
            //);

            // 2.2 to 3.0
            services
                .AddMvc()
                ;

            //------------------------------------------------------------------
            // HolisticWare custom Configuration Extension Methods in
            //     ./Startups/ 
            // folder
            services
                .ConfigureServicesAPIWebAPISwagger()
                .ConfigureServicesSessionTempData()
                .AddSingleton<Data.Ph4ct3xApplicationData>()
                .ConfigureServicesAPISignalR()
                ;
            //------------------------------------------------------------------

            return;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void ConfigureProduction
                        (
                            IApplicationBuilder app, 
                            IHostingEnvironment env,
                            Microsoft.Extensions.Logging.ILoggerFactory log
                        )
        {
            Startup.HostingEnvironment = env;

            app
                .UseExceptionHandler("/Error")
                ;

            app
                .UseSwagger()
                .UseSwaggerUI
                (
                    c =>
                    {
                        c.SwaggerEndpoint
                            (
                                $"/swagger/{Settings.Ph4ct3xSettings.APIVersion}/swagger.json",
                                Settings.Ph4ct3xSettings.Title
                            );
                    }
                )
                .UseStaticFiles()
                // enable session before MVC
                // https://andrewlock.net/an-introduction-to-session-storage-in-asp-net-core/
                .UseSession()
                ;

            // 2.2 to 3.0 
            app
                .UseMvc
                (
                    routes =>
                        {
                            routes.MapRoute
                                      (
                                          name: "default",
                                          template: "{controller}/{action=Index}/{id?}"
                                      );
                        }
                )
                ;

            return;
        }
    }
}
