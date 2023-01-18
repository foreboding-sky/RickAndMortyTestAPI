using RickAndMortyTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickAndMortyTestAPI.Data
{
    public class RickAndMortyRepository : IRickAndMortyRepository
    {
        public Task<bool> CheckPerson(string name, string episodeName)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPerson(string name)
        {
            throw new NotImplementedException();
        }
    }
}