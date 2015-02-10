using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace Ph4ct3x.Server
{
    public class Startup
    {
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();

			return;
		}
		public void Configure(IApplicationBuilder app)
        {
			// For more information on how to configure your application, 
			// visit http://go.microsoft.com/fwlink/?LinkID=398940

			app.UseMvc();
			app.UseWelcomePage();

			return;
		}

	}
}
