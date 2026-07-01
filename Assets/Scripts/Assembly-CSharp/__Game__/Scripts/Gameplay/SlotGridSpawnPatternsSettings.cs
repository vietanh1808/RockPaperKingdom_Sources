using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "SlotGridSpawnPatternsSettings", menuName = "TapHub/Stage/Slot Grid Spawn Patterns Settings")]
	public class SlotGridSpawnPatternsSettings : ScriptableObject
	{
		[SerializeField]
		private List<SlotGridSpawnPositions> _spawnPatterns;

		public List<Vector3> GetSpawnPoints(int amount)
		{
			return null;
		}

		public void SetSpawnPatterns(List<SlotGridSpawnPositions> patterns)
		{
		}
	}
}
