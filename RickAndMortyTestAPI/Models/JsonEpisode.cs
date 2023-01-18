using Newtonsoft.Json;

namespace RickAndMortyTestAPI.Models
{
    public class JsonEpisode
    {
        [JsonProperty("results")]
        public List<Episode> Episodes { get; set; }
    }
}