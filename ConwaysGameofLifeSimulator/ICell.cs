using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConwaysGameofLifeSimulator
{
    public interface ICell
    {
        bool IsAlive { get; set; }
        List<ICell> Neighbors { get; }
    }
}