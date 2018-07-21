using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class BrainArea
    {
        List<Neuron> neurons;
        string purpose; //Description of brain area purpose

        public BrainArea(string parPurpose)
        {
            this.purpose = parPurpose;
        }

        public List<Neuron> GetAllNeurons()
        {
            return this.neurons;
        }

        public List<Neuron> GetNeuronsOfLayer(int parLayer)
        {
            List<Neuron> tempNeuronList = new List<Neuron>();
            int tempNeuronListCounter = 0;
            for (int i = 0; i < this.neurons.Count(); i++)
            {
                if (neurons[i].GetLayer() == parLayer)
                {
                    tempNeuronList[tempNeuronListCounter] = neurons[i];
                    tempNeuronListCounter++;
                }
            }
            return tempNeuronList;
        }

        public void AddNeuron(Neuron parNeuron)
        {
            neurons[neurons.Count()] = parNeuron;
        }
    }
}
