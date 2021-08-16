using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron1 
{
	#region Variables
		public int numInputs;
		public double bias;
		public double output;
		public double errorGradient;
		public List<double> weights = new List<double>();
		public List<double> inputs = new List<double>();
	#endregion


	public Neuron1(int nInputs)
	{
		float weightRange = (float)2.4 / (float)nInputs;
		bias = Random.Range(-weightRange, weightRange);
		numInputs = nInputs;

		for (int i = 0; i < nInputs; i++)
			weights.Add(Random.Range(-weightRange, weightRange));
	}
}
