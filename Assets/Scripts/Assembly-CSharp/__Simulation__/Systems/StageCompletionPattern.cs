using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Simulation__.Systems
{
	[Serializable]
	public class StageCompletionPattern
	{
		[SerializeField]
		private List<float> _completionPercentPattern;

		public float GetCompletionPercent(int index)
		{
			return 0f;
		}
	}
}
