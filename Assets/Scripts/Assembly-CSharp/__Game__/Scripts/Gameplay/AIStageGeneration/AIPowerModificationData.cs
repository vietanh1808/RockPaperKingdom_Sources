using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[Serializable]
	public class AIPowerModificationData
	{
		[TextArea(5, 10)]
		[SerializeField]
		private string _lastFixPowersJson;

		private string _generationStatus;
	}
}
