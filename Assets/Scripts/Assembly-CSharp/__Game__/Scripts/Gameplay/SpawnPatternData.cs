using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class SpawnPatternData
	{
		[SerializeField]
		private int _unitsToSpawn;

		[Header("Formation")]
		[SerializeField]
		private SpawnPatternType _spawnPatternType;

		[SerializeField]
		private int _unitsPerRow;

		[SerializeField]
		private float _spawnOffset;

		public SpawnPatternType SpawnPatternType => default(SpawnPatternType);

		public int UnitsToSpawn => 0;

		public int UnitsPerRow => 0;

		public float SpawnOffset => 0f;

		private bool UseUnitsPerRow => false;

		public void SetUnitsToSpawn(int amount)
		{
		}
	}
}
