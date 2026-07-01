using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingRuntime : IBuildingAbilityProvider
	{
		private readonly BaseBuildingData _baseBuildingData;

		public EmptyNeighborBonusTracker EmptyNeighborBonusTracker { get; private set; }

		public AdjacentUnitsCountBonusTracker AdjacentUnitsCountBonusTracker { get; private set; }

		public AdjacentBuildingBonusTracker AdjacentBuildingBonusTracker { get; private set; }

		public InventoryResourceBonusTracker InventoryResourceBonusTracker { get; private set; }

		public GlobalBuildingCountBonusTracker GlobalBuildingCountBonusTracker { get; private set; }

		public int LevelIndex { get; private set; }

		public int MaxLevelIndex => 0;

		public SharedUnit SharedUnit { get; private set; }

		public SharedAbility MainSharedAbility { get; private set; }

		public Vector2Int SlotGridPosition { get; private set; }

		public TowerStats TowerStats { get; }

		public event Action OnLevelChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public BuildingRuntime(BaseBuildingData baseBuildingData, SharedUnit sharedUnitData)
		{
		}

		public void SetSlotGridPosition(Vector2Int position)
		{
		}

		public void SetSharedUnit(SharedUnit sharedUnit)
		{
		}

		public void SetMainSharedAbility(SharedAbility sharedAbility)
		{
		}

		public void IncreaseLevel()
		{
		}

		public void RestoreLevelIndex()
		{
		}

		public void InitializeNeighborBonuses(BuildingSlot buildingSlot, bool applyBonus)
		{
		}

		public void InitializeInventoryResourceBonus(GameplayInventorySystem inventorySystem, bool applyBonus)
		{
		}

		public void InitializeGlobalBuildingBonus(BuildingRepository buildingRepository, bool applyBonus)
		{
		}

		public void RestoreNeighborBonuses()
		{
		}

		public void Dispose()
		{
		}

		private void ApplyLevelUpModifications()
		{
		}

		public SharedAbility GetAbility(AbilityTargetType targetType)
		{
			return null;
		}
	}
}
