using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    //A neuron input
    class Dendrit
    {
        Axon connection;
        Neuron parentNeuron;
        float weight;
        bool activated;

        public Dendrit(Neuron parParentNeuron, Axon outputFromNeuron)
        {
            this.parentNeuron = parParentNeuron;
            this.connection = outputFromNeuron;
            this.weight = outputFromNeuron.getWeight();
            this.activated = false;
        }

        public void setWeight(float newWeight)
        {
            this.weight = newWeight;
        }

        public float getWeight()
        {
            return this.weight;
        }

        public void activateDendrit()
        {
            this.activated = true;
        }

        public void deactivateDendrit()
        {
            this.activated = false;
        }

        public bool isActivated()
        {
            return this.activated;
        }

    }
}
