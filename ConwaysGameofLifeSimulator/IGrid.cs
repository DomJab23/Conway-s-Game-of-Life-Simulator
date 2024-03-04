using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConwaysGameofLifeSimulator
{
    public interface IGrid
    {
        public void UpdateState();
        public void GetCellState();
    }
}