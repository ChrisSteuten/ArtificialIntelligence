using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    class WeightedSumAndSquashNeuron : Neuron
    {

        public WeightedSumAndSquashNeuron(BrainArea parBrainArea, int parLayer) : base(parBrainArea, parLayer)
        {

        }

        public override void ProcessInputs()
        {
            double tempValue = this.SumInputConnectionValues();
            tempValue = SquashValue(tempValue);

            this.value = tempValue;
            
        }

        private double SquashValue(double input)
        {
            return (1 / (1 + Math.E  - input));
        }



    }
}
