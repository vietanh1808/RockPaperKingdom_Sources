using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration.SimulationBalancing
{
	[Serializable]
	public class IterationPromptEntry
	{
		public string Title;

		[TextArea(5, 20)]
		public string Prompt;

		public IterationPromptEntry(int iteration, string prompt)
		{
		}
	}
}
