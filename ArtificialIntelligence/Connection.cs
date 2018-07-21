using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class Connection
    {
        Neuron sourceNeuron;
        Neuron targetNeuron;
        double weight;

        public Connection(Neuron parSourceNeuron, Neuron parTargetNeuron)
        {
            this.sourceNeuron = parSourceNeuron;
            this.targetNeuron = parTargetNeuron;
            this.weight = 1;
        }

        public Connection(Neuron parSourceNeuron, Neuron parTargetNeuron, double parWeight)
        {
            this.sourceNeuron = parSourceNeuron;
            this.targetNeuron = parTargetNeuron;
            this.weight = parWeight;
        }


        public Neuron GetSourceNeuron()
        {
            return this.sourceNeuron;
        }

        public Neuron GetTargetNeuron()
        {
            return this.targetNeuron;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(double newWeight)
        {
            this.weight = newWeight;
        }
    }
}
