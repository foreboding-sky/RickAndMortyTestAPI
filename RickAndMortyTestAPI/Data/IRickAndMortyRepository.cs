using RickAndMortyTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickAndMortyTestAPI.Data
{
    public interface IRickAndMortyRepository
    {
        public Task<bool?> CheckPerson(string personName, string episodeName);
        public Task<JsonPerson> GetPerson(string name);
    }
}