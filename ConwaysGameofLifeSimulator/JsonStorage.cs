using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConwaysGameofLifeSimulator
{
    public class JsonStorage : IStorage
    {
        public void Load()
        {

        }
        public void Save()
        {
            var storage = JsonSerializer.Serialize("JsonStorage.json");
        }
    }
}