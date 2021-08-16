using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer1 
{
	#region Variables
		public int numNeurons;
		public List<Neuron1> neurons = new List<Neuron1>();
	#endregion

	public Layer1(int nNeurons, int numNeuronInputs)
	{
		numNeurons = nNeurons;
		for (int i = 0; i < nNeurons; i++)
		{
			neurons.Add(new Neuron1(numNeuronInputs));
		}
	}
}
