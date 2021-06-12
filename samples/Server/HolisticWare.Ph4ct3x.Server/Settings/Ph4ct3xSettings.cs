using System;

using Microsoft.AspNetCore.Hosting;

namespace HolisticWare.Ph4ct3x.Server.Settings
{
    public class Ph4ct3xSettings
    {
        public Ph4ct3xSettings()
        {
        }

        public static string Name
        {
            get;
            set;
        } = "HolisticWare.Ph4ct3x";

        public static string Title
        {
            get;
            set;
        } = "Ph4ct3x Physical Activity Exper System API";

        public static string APIVersion
        {
            get;
            set;
        } = "2017.12.28";

        public static uint SessionTimeOut
        {
            get
            {
                if (Startup.HostingEnvironment.IsDevelopment())
                {
                    return 30;
                }
                else
                {
                    return 600;
                }
            }
        }

    }
}
