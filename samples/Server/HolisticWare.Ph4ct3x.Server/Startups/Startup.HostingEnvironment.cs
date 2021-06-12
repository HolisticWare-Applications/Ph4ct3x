using System;

using Microsoft.AspNetCore.Hosting;

namespace HolisticWare.Ph4ct3x.Server
{
    // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments
    //  ASPNETCORE_ENVIRONMENT
    //          Development
    //          Staging
    //          Production
    public partial class Startup
    {
        public static IHostingEnvironment HostingEnvironment 
        { 
            get; 
            private set; 
        }


    }
}
