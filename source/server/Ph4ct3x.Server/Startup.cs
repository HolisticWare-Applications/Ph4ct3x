
using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

using Microsoft.Framework.ConfigurationModel;

namespace Ph4ct3x.Server
{
    public class Startup
    {
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddHosting();
			services.AddOptions();
			services.AddLogging();
			services.AddMvc();


			// configuring services
			//		force JSON
			//		remove XML
			services.Configure<Microsoft.AspNet.Mvc.MvcOptions>
					(
						options 
						=>
							options
							.OutputFormatters
							.RemoveAll
								(
									formatter 
									=> 
									formatter.Instance 
										is 
										Microsoft.AspNet.Mvc.XmlDataContractSerializerOutputFormatter
								)
					);

			return;
		}
		public void Configure(IApplicationBuilder app)
        {
			// For more information on how to configure your application, 
			// visit http://go.microsoft.com/fwlink/?LinkID=398940

			// Setup configuration sources
			Configuration configuration = new Configuration();

			configuration.AddJsonFile("config.json");
			configuration.AddIniFile("config.ini");
			// this cannot be accessed if XML fomratters were removed
			configuration.AddXmlFile("config.xml");
			configuration.AddEnvironmentVariables();

			string url_home = configuration.Get<string>("UrlLogo");

			app.UseMvc();
			app.UseWelcomePage();

			return;
		}

	}
}
