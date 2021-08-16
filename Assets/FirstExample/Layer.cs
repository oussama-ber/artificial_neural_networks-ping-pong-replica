using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer 
{
	#region Variables
		public int numNeurons;
		public List<Neuron> neurons = new List<Neuron>();
	#endregion

	public Layer(int nNeurons, int numNeuronsInputs)
    {
		numNeurons = nNeurons;
        for (int i = 0; i < nNeurons; i++)
        {
			neurons.Add(new Neuron(numNeuronsInputs));
        }
    }
}
