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
        public async Task<bool> CheckPerson(string name, string episodeName)
        {
            throw new NotImplementedException();
        }

        public async Task<JsonData> GetPerson(string name)
        {
            using (HttpResponseMessage response = await Client.GetAsync("https://rickandmortyapi.com/api/character/?name=" + name))
            {
                JsonData person = new JsonData();
                if (response.IsSuccessStatusCode)
                {
                    person = await response.Content.ReadAsAsync<JsonData>();
                }
                return person;
            }
            throw new NotImplementedException("Http response instance not created");
        }
    }
}