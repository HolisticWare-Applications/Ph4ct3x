using Microsoft.AspNetCore.Builder;

namespace HolisticWare.Ph4ct3x.Server
{
    public partial class Startup
    {
        // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-2.1&tabs=aspnetcore2x

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            return;
        }
    }
}
