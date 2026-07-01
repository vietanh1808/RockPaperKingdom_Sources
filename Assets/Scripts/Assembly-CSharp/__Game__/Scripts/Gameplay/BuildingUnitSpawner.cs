using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingUnitSpawner : MonoBehaviour
	{
		[SerializeField]
		private List<SlotGridSpawnPoint> _spawnerSlots;

		private SlotGridSpawnPatternsSettings _spawnPatternsSettings;

		private UnitPoolManager _unitPoolManager;

		private BuildingSlotGrid _buildingSlotGrid;

		private SlotGridSpawnPoint[,] _slotsArray;

		[Inject]
		private void Inject(SlotGridSpawnPatternsSettings spawnPatternsSettings, UnitPoolManager unitPoolManager)
		{
		}

		public void SetBuildingSlotGrid(BuildingSlotGrid buildingSlotGrid)
		{
		}

		public void SetUnitPoolManager(UnitPoolManager unitPoolManager)
		{
		}

		private void Awake()
		{
		}

		private void InitializeSlotsArray()
		{
		}

		public void SpawnAllUnitsToCapacity()
		{
		}

		public List<BaseUnit> SpawnUnitsForBuilding(BuildingRuntime buildingRuntime, Vector3 buildingWorldPosition)
		{
			return null;
		}

		private Vector3 GetSpawnPosition(List<Vector3> spawnPoints, Vector3 slotPosition, int spawnIndex)
		{
			return default(Vector3);
		}

		public void DespawnAliveUnits(List<BaseUnit> units)
		{
		}
	}
}
