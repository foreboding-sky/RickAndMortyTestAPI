using RickAndMortyTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace RickAndMortyTestAPI.Data
{
    public class RickAndMortyRepository : IRickAndMortyRepository
    {
        public HttpClient Client { get; set; }
        public RickAndMortyRepository()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<bool?> CheckPerson(string personName, string episodeName)
        {
            using HttpResponseMessage response = await Client.GetAsync("https://rickandmortyapi.com/api/episode/?name=" + episodeName);
            if (response.IsSuccessStatusCode)
            {
                JsonEpisode result = await response.Content.ReadAsAsync<JsonEpisode>();
                foreach (var episode in result.Episodes)
                {
                    foreach (var character in episode.Characters)
                    {
                        using (HttpResponseMessage responseCharacter = await Client.GetAsync(character))
                        {
                            if (responseCharacter.IsSuccessStatusCode)
                            {
                                Person person = await responseCharacter.Content.ReadAsAsync<Person>();
                                if (person.Name.Contains(personName))
                                    return true;
                            }
                        }
                    }
                }
                return false;
            }
            return null;
        }

        public async Task<JsonPerson> GetPerson(string name)
        {
            JsonPerson person = new JsonPerson();
            using HttpResponseMessage response = await Client.GetAsync("https://rickandmortyapi.com/api/character/?name=" + name);

            if (response.IsSuccessStatusCode)
            {
                person = await response.Content.ReadAsAsync<JsonPerson>();
            }
            return person;
        }

    }
}