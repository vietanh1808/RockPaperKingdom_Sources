using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class SpawnUnit : AbilityObjectComponent
	{
		[SerializeField]
		private UnitData _unitData;

		private SharedUnitRepository _sharedUnitRepository;

		private UnitPoolManager _unitPoolManager;

		private AbilitySpawnedUnitsTracker _abilitySpawnedUnitsTracker;

		[Inject]
		private void Inject(UnitPoolManager unitPoolManager, SharedUnitRepository sharedUnitRepository, AbilitySpawnedUnitsTracker abilitySpawnedUnitsTracker)
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void InvokeSpawnUnit(Transform followTransform, float spawnRadius)
		{
		}
	}
}
