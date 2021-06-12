using System;

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HolisticWare.Ph4ct3x.Server.ExtensionMethods
{
    // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?tabs=aspnetcore2x#configuring-session
    public static partial class SessionExtensionMethods
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));

            return;
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) :
                                  JsonConvert.DeserializeObject<T>(value);
        }
    }
}
