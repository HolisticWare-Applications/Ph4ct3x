using System;

namespace HolisticWare.Ph4ct3x.Server.API.SignalR
{
    public class HubChat : Microsoft.AspNetCore.SignalR.Hub
    {
        public System.Threading.Tasks.Task Send(object[] message)
        {
            return Clients.All.SendCoreAsync("Send", message);
        }
    }
}
