using Newtonsoft.Json;

namespace RickAndMortyTestAPI.Models
{
    public class JsonPerson
    {
        [JsonProperty("results")]
        public List<Person> People { get; set; }
    }
}