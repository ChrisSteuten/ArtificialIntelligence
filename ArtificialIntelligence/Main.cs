using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class Main
    {
        public Main()
        {
            Brain bob = new Brain("Bob");
            bob.addBrainArea("NumberRecognising");
            BrainArea NumbRecog = bob.getBrainArea(bob.getBrainAreasCount() - 1);
            NumbRecog.addNeuron();


        }
    }
}
