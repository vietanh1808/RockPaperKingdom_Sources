using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class InventoryResourceBonusTracker
	{
		private readonly AssetModuleHolder<BaseBuildingUpgradeModule> _bonusModules;

		private readonly BuildingRuntime _buildingRuntime;

		private readonly GameplayInventorySystem _inventorySystem;

		private readonly string _trackedItemGuid;

		private readonly int _amountPerIncrease;

		private readonly Dictionary<UnitStatType, float> _appliedUnitAdditives;

		private readonly Dictionary<UnitStatType, float> _appliedUnitMultipliers;

		private readonly Dictionary<AbilityStatType, float> _appliedAbilityAdditives;

		private readonly Dictionary<AbilityStatType, float> _appliedAbilityMultipliers;

		public int CurrentBonusStacks { get; private set; }

		public event Action<int> OnBonusStacksChanged
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

		public InventoryResourceBonusTracker(AssetModuleHolder<BaseBuildingUpgradeModule> bonusModules, BuildingRuntime buildingRuntime, GameplayInventorySystem inventorySystem, InventoryItemData trackedItem, int amountPerIncrease)
		{
		}

		public void Recalculate()
		{
		}

		public void RestoreCount()
		{
		}

		public void Dispose()
		{
		}

		private void HandleItemAmountChanged(InventoryItem item)
		{
		}

		private int CalculateBonusStacks()
		{
			return 0;
		}

		private void SyncAppliedValues(int stacks)
		{
		}

		private void ApplyDeltaModifiers(int stacks)
		{
		}

		private void ApplyAddUnitStatDelta(AddStatUnitBuildingUpgradeModule module, int stacks)
		{
		}

		private void ApplyMultiplyUnitStatDelta(MultiplyStatUnitBuildingUpgradeModule module, int stacks)
		{
		}

		private void ApplyAddAbilityStatDelta(AddStatAbilityBuildingUpgradeModule module, int stacks)
		{
		}

		private void ApplyMultiplyAbilityStatDelta(MultiplyStatAbilityBuildingUpgradeModule module, int stacks)
		{
		}
	}
}
