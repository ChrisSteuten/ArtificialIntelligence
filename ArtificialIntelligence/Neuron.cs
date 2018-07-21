using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    //Encapsulating class
    class Neuron
    {
        private Cell processingUnit;
        private Dendrit[] inputs;
        private Axon output;

        public Neuron()
        {
            this.processingUnit = new Cell(this);

            this.output = new Axon(this);
        }

        public Dendrit addDendrit(Axon neuronOutput)
        {
            Dendrit newDendrit = new Dendrit(this, neuronOutput);
            return newDendrit;
        }

        public void connectAxon(Neuron connectTo)
        {
            connectTo.addDendrit(this.output);
        }

        public Axon getAxon()
        {
            return this.output;
        }

        public void processInputs()
        {
            this.processingUnit.process(inputs);
        }
    }

}
