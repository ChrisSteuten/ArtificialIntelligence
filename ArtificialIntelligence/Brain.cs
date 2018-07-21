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
        List<BrainArea> brainAreas;

        public Brain(string parName)
        {
            this.name = parName;
        }

        public List<BrainArea> GetBrainAreas()
        {
            return this.brainAreas;
        }

        public int GetBrainAreasCount()
        {
            return brainAreas.Count();
        }

        public BrainArea GetBrainArea(int index)
        {
            return brainAreas[index];
        }

        public void AddBrainArea(BrainArea parBrainArea)
        {
            brainAreas[brainAreas.Count()] = parBrainArea;
        }

        public List<Neuron> GetAllNeurons()
        {
            List<Neuron> tempNeuronList = new List<Neuron>();
            for (int brainAreaCount = 0; brainAreaCount < brainAreas.Count(); brainAreaCount++)
            {
                tempNeuronList.AddRange(brainAreas[brainAreaCount].GetAllNeurons());
            }

            return tempNeuronList;
        }
    }
}
