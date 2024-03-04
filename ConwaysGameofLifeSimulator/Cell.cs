using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConwaysGameofLifeSimulator
{
    public class Cell : ICell
    {
        public bool IsAlive { get; set; }
        public List<ICell> Neighbors { get; } = new List<ICell>();
    }
}