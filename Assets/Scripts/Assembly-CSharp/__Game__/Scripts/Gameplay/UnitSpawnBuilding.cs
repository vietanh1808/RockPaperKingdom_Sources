using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class UnitSpawnBuilding : BaseBuilding
	{
		private BuildingUnitsHolder _unitsHolder;

		private StatValue _unitsAmountStat;

		public UnitSpawnBuildingData UnitSpawnBuildingData { get; private set; }

		public BuildingUnitsHolder UnitsHolder => null;

		public override bool HasSpawnableUnits => false;

		public void Construct(UnitSpawnBuildingData buildingData, BuildingRuntime building, BuildingUnitSpawner unitSpawner)
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void SetBuildingState(BuildingState state)
		{
		}

		public override void OnBuildingPlaced(BuildingSlot buildingSlot, bool isRestore = false)
		{
		}

		public override void IncreaseLevel()
		{
		}

		public override void DespawnUnits()
		{
		}

		public void SpawnUnits()
		{
		}

		public override void SetSkinActiveState(bool isActive)
		{
		}

		private void SubscribeToUnitsAmountChanges()
		{
		}

		private void UnsubscribeFromUnitsAmountChanges()
		{
		}

		private void OnUnitsAmountChanged(StatValue stat)
		{
		}

		private void RespawnUnits()
		{
		}

		private void ActivateSecondaryAbilities()
		{
		}

		private void DeactivateSecondaryAbilities()
		{
		}
	}
}
