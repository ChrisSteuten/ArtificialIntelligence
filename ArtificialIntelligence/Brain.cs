using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class Brain
    {
        string name;
        BrainArea[] brainAreas;

        public Brain(string parName)
        {
            this.name = parName;
        }

        public BrainArea[] getBrainAreas()
        {
            return this.brainAreas;
        }

        public int getBrainAreasCount()
        {
            return brainAreas.Count();
        }

        public BrainArea getBrainArea(int index)
        {
            return brainAreas[index];
        }

        public void addBrainArea(string purpose)
        {
            brainAreas[brainAreas.Count()] = new BrainArea(purpose);
        }
    }
}
