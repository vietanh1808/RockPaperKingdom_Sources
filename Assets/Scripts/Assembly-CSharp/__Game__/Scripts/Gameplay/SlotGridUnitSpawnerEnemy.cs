using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Boss;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class SlotGridUnitSpawnerEnemy : MonoBehaviour
	{
		private SlotGridSpawnPatternsSettings _spawnPatternsSettings;

		private UnitPoolManager _unitPoolManager;

		private SharedUnitRepository _enemySharedUnitRepository;

		private BossFightController _bossFightController;

		private WaveSystem _waveSystem;

		public bool IsBossSpawned { get; private set; }

		[Inject]
		private void Inject(SlotGridSpawnPatternsSettings spawnPatternsSettings, UnitPoolManager unitPoolManager, GameplayEnemySharedUnitFactory gameplayEnemySharedUnitFactory, BossFightController bossFightController, WaveSystem waveSystem)
		{
		}

		public void SpawnUnitsToGrid(List<WaveSpawnSlot> waveSpawnSlots)
		{
		}

		private void SpawnUnitsToSlot(UnitData unitData, int unitsAmount, Vector3 slotPosition)
		{
		}

		private Vector3 GetSpawnPosition(List<Vector3> spawnPoints, Vector3 slotPosition, int spawnIndex)
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
	}
}
