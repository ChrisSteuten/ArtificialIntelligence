using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    //Processing unit which processes all inputs and creates one output
    class Cell
    {

        Neuron parentNeuron;
        float activationValue;

        public Cell(Neuron parParentNeuron)
        {
            parentNeuron = parParentNeuron;
            activationValue = 1;
        }

        public void process(Dendrit[] inputs)
        {
            float inputSum = sumInputs(inputs);
            if (inputSum >= activationValue)
            {
                this.parentNeuron.getAxon().activateAxon();
            } 
        }

        public void setActivationValue(float newActivationValue)
        {
            this.activationValue = newActivationValue;
        }

        private float sumInputs(Dendrit[] inputs)
        {
            float inputSum = 0;
            for (int i = 0; i < inputs.Count(); i++)
            {
                if (inputs[i].isActivated())
                {
                    inputSum += inputs[i].getWeight();
                    inputs[i].deactivateDendrit();
                }
            }
            return inputSum;
        }

    }
}
