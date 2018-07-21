using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class InputNeuron : Neuron
    {
        public InputNeuron(BrainArea parBrainArea, int parLayer) : base(parBrainArea, parLayer)
        {

        }

        public override void ProcessInputs()
        {
        }

        public void SetValue(double newValue)
        {
            this.value = newValue;
        }
    }
}
