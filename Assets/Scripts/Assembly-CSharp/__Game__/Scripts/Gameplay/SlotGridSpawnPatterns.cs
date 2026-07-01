using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class SlotGridSpawnPatterns : MonoBehaviour
	{
		[SerializeField]
		private List<SlotGridSpawnPattern> _spawnPatterns;

		[SerializeField]
		private SlotGridSpawnPatternsSettings _settings;

		private void SavePatternsToSettings()
		{
		}
	}
}
