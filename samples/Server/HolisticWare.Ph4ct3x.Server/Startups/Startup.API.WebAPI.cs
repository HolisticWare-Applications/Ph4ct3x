using System;

using Microsoft.Extensions.DependencyInjection;

namespace HolisticWare.Ph4ct3x.Server
{
    public partial class Startup
    {
        private void ConfigureServicesAPIWebAPISwagger(IServiceCollection services)
        {
            services.AddSwaggerGen
                    (
                        c =>
                        {
                            c.SwaggerDoc
                                (
                                    Settings.Ph4ct3xSettings.APIVersion,
                                    new Swashbuckle.AspNetCore.Swagger.Info
                                    {
                                        Title = Settings.Ph4ct3xSettings.Title,
                                        Version = Settings.Ph4ct3xSettings.APIVersion
                                    }
                                );
                        }
                   );

            services.ConfigureSwaggerGen
                        (
                            options =>
                            {
                                options.DescribeAllEnumsAsStrings();
                            }
                        );

            return;
        }
    }
}
