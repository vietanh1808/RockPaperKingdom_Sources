using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[Serializable]
	public class AIGeneratedOutputData
	{
		[TextArea(5, 15)]
		[SerializeField]
		private string _lastGeneratedJson;

		[TextArea(5, 20)]
		[SerializeField]
		private string _lastPrompt;

		private string _generationStatus;

		public string LastGeneratedJson => null;

		public string LastPrompt => null;

		public string GenerationStatus => null;
	}
}
