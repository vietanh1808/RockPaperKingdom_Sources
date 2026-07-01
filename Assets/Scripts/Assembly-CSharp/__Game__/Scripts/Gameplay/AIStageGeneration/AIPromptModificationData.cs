using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[Serializable]
	public class AIPromptModificationData
	{
		[TextArea(5, 10)]
		[SerializeField]
		private string _modificationPrompt;

		[TextArea(5, 10)]
		[SerializeField]
		private string _lastCustomModificationJson;

		private string _generationStatus;
	}
}
