using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    //A neuron output
    class Axon
    {
        Dendrit[] connections;
        Neuron parentNeuron;
        float weight;
        bool activated;

        public Axon(Neuron parParentNeuron)
        {
            this.parentNeuron = parParentNeuron;
            this.weight = 0;
        }

        public void connectToNeuron(Neuron neuron)
        {
            neuron.addDendrit(this); //Connects this Axon with a new Dendrit of the given Neuron
        }

        public void setWeight(float newWeight)
        {
            this.weight = newWeight;
            for(int i = 0; i < connections.Count(); i++)
            {
                this.connections[i].setWeight(newWeight);
            }
        }

        public float getWeight()
        {
            return this.weight;
        }

        public bool hasConnections()
        {
            return this.connections.Count() > 0;
        }

        public void activateAxon()
        {
            for(int i = 0; i < this.connections.Count(); i++)
            {
                this.connections[i].activateDendrit();
            }
        }

        public void deactivateAxon()
        {
            for (int i = 0; i < this.connections.Count(); i++)
            {
                this.connections[i].deactivateDendrit();
            }
        }
    }
}
