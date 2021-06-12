using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Internal
{
    public static class Serializer
    {
        public static string ToJson(this Dictionary<string, Categories> self)
            =>
            JsonConvert.SerializeObject(self, Converter.Settings);

        public static string ToJson(this SearchAllResult[] self)
            =>
        JsonConvert.SerializeObject(self, Converter.Settings);

    }
}
