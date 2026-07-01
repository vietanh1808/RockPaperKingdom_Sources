using System.Collections.Generic;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayUpgradesRepository
	{
		private readonly List<BaseGameplayUpgrade> _availableUpgrades;

		private readonly List<BaseGameplayUpgrade> _removedUpgrades;

		private readonly Dictionary<BaseGameplayUpgrade, int> _appliedCount;

		private readonly UpgradesConfig _upgradesConfig;

		private readonly StageData _stageData;

		public GameplayUpgradesRepository(UpgradesConfig upgradesConfig)
		{
		}

		public IReadOnlyList<BaseGameplayUpgrade> GetAvailableUpgrades()
		{
			return null;
		}

		public void AddUpgrade(BaseGameplayUpgrade upgrade)
		{
		}

		public void ProcessUpgradeApplication(BaseGameplayUpgrade appliedUpgrade)
		{
		}

		private void RecordUpgradeApplication(BaseGameplayUpgrade upgrade)
		{
		}

		public void AddUpgrades(BaseGameplayUpgrade[] upgradesToAdd)
		{
		}

		public void RemoveUpgrades(BaseGameplayUpgrade[] upgradesToRemove)
		{
		}

		private void RemoveUpgrade(BaseGameplayUpgrade upgrade)
		{
		}

		private void IncrementAppliedCount(BaseGameplayUpgrade upgrade)
		{
		}

		private void RemoveUpgradeFromAvailable(BaseGameplayUpgrade upgrade)
		{
		}
	}
}
