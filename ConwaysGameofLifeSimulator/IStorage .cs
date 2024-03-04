using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConwaysGameofLifeSimulator
{
    public interface IStorage 
    {
        public void Load();
        public void Save();
    }
}