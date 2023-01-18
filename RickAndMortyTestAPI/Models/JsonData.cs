using Newtonsoft.Json;

namespace RickAndMortyTestAPI.Models
{
    public class JsonData
    {
        [JsonProperty("results")]
        public List<Person> People { get; set; }
    }
}