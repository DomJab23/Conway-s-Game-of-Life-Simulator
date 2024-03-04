using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConwaysGameofLifeSimulator
{
    public interface ICell
    {
        public bool State();
        public bool Neighbor();
    }
}