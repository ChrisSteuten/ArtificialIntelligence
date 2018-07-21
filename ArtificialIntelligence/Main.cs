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
            BrainArea NumbRecog = new BrainArea("NumberRecognition");
            bob.AddBrainArea(NumbRecog);
            Neuron neuron = new InputNeuron(NumbRecog, 0);
            NumbRecog.AddNeuron(neuron);


        }
    }
}
