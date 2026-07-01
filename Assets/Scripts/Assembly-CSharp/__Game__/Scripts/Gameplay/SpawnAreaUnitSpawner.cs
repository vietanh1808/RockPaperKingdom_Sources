using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class SpawnAreaUnitSpawner : MonoBehaviour
	{
		[SerializeField]
		private Bounds _spawnArea;

		private UnitPoolManager _unitPoolManager;

		private WaveSystem _waveSystem;

		private SharedUnitRepository _sharedUnitRepository;

		[Inject]
		private void Inject(UnitPoolManager enemyPoolManager, WaveSystem waveSystem, SharedUnitRepository sharedUnitRepository)
		{
		}

		public BaseUnit SpawnUnit(UnitData unitData, Vector3 spawnPosition)
		{
			return null;
		}

		public BaseUnit SpawnUnit(UnitData unitData)
		{
			return null;
		}

		public void SpawnUnit(UnitData unitData, SpawnPatternData pattern)
		{
		}

		private void SpawnRandomPattern(UnitData unitData, int unitsToSpawn)
		{
		}

		private void SpawnGridPattern(UnitData unitData, int unitsToSpawn, int unitsPerRow, float spawnOffset)
		{
		}

		private void SpawnCascadePattern(UnitData unitData, int unitsToSpawn, int unitsPerRow, float spawnOffset)
		{
		}

		private Vector3 GetRandomPosition(float maxRowWidth = 0f)
		{
			return default(Vector3);
		}

		private float GetHealthMultiplier()
		{
			return 0f;
		}

		private float GetDamageMultiplier()
		{
			return 0f;
		}

		private float GetCastleDamageMultiplier()
		{
			return 0f;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
