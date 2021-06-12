using System;

using Microsoft.Extensions.DependencyInjection;

namespace HolisticWare.Ph4ct3x.Server
{
    public static partial class StartupAPISignalR
    {
        public static IServiceCollection ConfigureServicesAPISignalR(this IServiceCollection services)
        {
            /*
            <!--
            =============================================================================================
            SignalR
            -->  
            <ItemGroup>
                <PackageReference Include="Microsoft.AspNetCore.SignalR" Version="1.0.0-alpha1-final" />
            </ItemGroup>
            <ItemGroup>
                <Folder Include="wwwroot\scripts\signalr\" />
            </ItemGroup>
            <!--
            SignalR
            =============================================================================================
            -->  
            */

            //------------------------------------------------------------------
            #region    SignalR
            services.AddSignalR();
            #endregion SignalR
            //------------------------------------------------------------------

            return services;
        }
    }
}
