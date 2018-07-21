using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class BrainArea
    {
        Neuron[] neurons;
        string purpose; //Description of brain area purpose

        public BrainArea(string parPurpose)
        {
            this.purpose = parPurpose;
        }

        public Neuron[] getNeurons()
        {
            return this.neurons;
        }

        public void addNeuron()
        {
            neurons[neurons.Count()] = new Neuron();
        }
    }
}
