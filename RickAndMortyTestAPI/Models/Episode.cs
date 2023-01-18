using Newtonsoft.Json;

namespace RickAndMortyTestAPI.Models
{
    public class Episode
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string AirDate { get; set; }
        [JsonProperty("episode")]
        public string Number { get; set; }
        public List<string> Characters { get; set; }
    }
}