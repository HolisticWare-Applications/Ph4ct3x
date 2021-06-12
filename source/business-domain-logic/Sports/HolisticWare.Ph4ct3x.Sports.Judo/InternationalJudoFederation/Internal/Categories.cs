using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Internal
{
    public partial class Categories
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("categories")]
        public Dictionary<string, Category> CategoriesCategories { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Categories
    {
        public static Dictionary<string, Categories> FromJson(string json)
            =>
            JsonConvert.DeserializeObject<Dictionary<string, Categories>>(json, Converter.Settings);
    }

}
