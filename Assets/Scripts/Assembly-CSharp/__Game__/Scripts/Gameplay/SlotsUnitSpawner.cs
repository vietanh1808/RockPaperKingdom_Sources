using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class SlotsUnitSpawner : MonoBehaviour
	{
		[SerializeField]
		private List<UnitSpawnerSlot> _spawnSlots;

		[SerializeField]
		private float _spawnRadius;

		private readonly Dictionary<UnitData, Transform> _spawnTransformByUnitData;

		private UnitPoolManager _unitPoolManager;

		private SharedUnitRepository _sharedUnitRepository;

		[Inject]
		private void Inject(UnitPoolManager poolManager, SharedUnitRepository sharedUnitRepository)
		{
		}

		private void Awake()
		{
		}

		public BaseUnit SpawnUnit(UnitData unitData)
		{
			return null;
		}

		private Vector3 GetRandomOffsetByRadius(float radius)
		{
			return default(Vector3);
		}

		private Vector3 GetSlotSpawnPosition(UnitData unitData)
		{
			return default(Vector3);
		}
	}
}
