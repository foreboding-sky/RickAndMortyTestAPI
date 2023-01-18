using RickAndMortyTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickAndMortyTestAPI.Data
{
    public interface IRickAndMortyRepository
    {
        public Task<bool> CheckPerson(string name, string episodeName);
        public Task<Person> GetPerson(string name);
    }
}