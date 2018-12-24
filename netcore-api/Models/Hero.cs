using Newtonsoft.Json;

namespace TourOfHeroesApi.Models
{
    public class Hero
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
