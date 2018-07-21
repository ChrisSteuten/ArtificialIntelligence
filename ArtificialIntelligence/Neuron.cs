using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligence
{
    //Encapsulating class
    abstract class Neuron
    {
        protected BrainArea brainArea;
        protected int layer;
        protected double value;
        protected List<Connection> inputConnections;
        protected List<Connection>  outputConnections;
     
        public Neuron(BrainArea parBrainArea, int parLayer)
        {
            this.brainArea = parBrainArea;
            this.layer = parLayer;
            List<Neuron> neuronList = new List<Neuron>();

            //Connect new neuron to all neurons on the layer under itself
            neuronList = parBrainArea.GetNeuronsOfLayer(parLayer - 1);
            for (int subLayerNeuron = 0; subLayerNeuron < neuronList.Count(); subLayerNeuron++)
            {
                Connection neuronConnection = new Connection(neuronList[subLayerNeuron], this);
                neuronList[subLayerNeuron].AddOutputConnection(neuronConnection);
                this.AddInputConnection(neuronConnection);
            }

            //Connect new neuron to all neurons on the layer above itself
            neuronList = parBrainArea.GetNeuronsOfLayer(parLayer + 1);
            for (int topLayerNeuron = 0; topLayerNeuron < neuronList.Count(); topLayerNeuron++)
            {
                Connection neuronConnection = new Connection(this, neuronList[topLayerNeuron]);
                neuronList[topLayerNeuron].AddInputConnection(neuronConnection);
                this.AddOutputConnection(neuronConnection);
            }

            parBrainArea.AddNeuron(this);
        }

        public double GetValue()
        {
            return this.value;
        }

        public int GetLayer()
        {
            return this.layer;
        }

        public void AddInputConnection(Connection newInputConnection)
        {
            this.inputConnections[this.inputConnections.Count()] = newInputConnection;
        }

        public void AddOutputConnection(Connection newOutputConnection)
        {
            this.outputConnections[this.outputConnections.Count()] = newOutputConnection;
        }

        protected double SumInputConnectionValues()
        {
            double tempValue = 0;
            for (int i = 0; i < this.inputConnections.Count(); i++)
            {
                tempValue = this.inputConnections[i].GetSourceNeuron().GetValue() * this.inputConnections[i].GetWeight();
            }
            return tempValue;
        }

        public abstract void ProcessInputs();

    }

}
