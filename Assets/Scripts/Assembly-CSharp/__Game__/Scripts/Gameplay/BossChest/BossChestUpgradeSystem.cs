using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.BossChest
{
	public class BossChestUpgradeSystem
	{
		private readonly BossChestUpgradeCollection _upgradeCollection;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly StageSystem _stageSystem;

		private int _currentRoundIndex;

		public List<BaseGameplayUpgrade> ActiveUpgradesSelection { get; private set; }

		public event Action<BaseGameplayUpgrade> OnBossChestUpgradeApplied
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

		public BossChestUpgradeSystem(BossChestUpgradeCollection upgradeCollection, GameplayUpgradesSystem gameplayUpgradesSystem, StageSystem stageSystem)
		{
		}

		public void Initialize()
		{
		}

		public List<BaseGameplayUpgrade> GetRandomUpgrades(int count)
		{
			return null;
		}

		public void NotifyUpgradeApplied(BaseGameplayUpgrade selectedUpgrade)
		{
		}

		private List<BaseGameplayUpgrade> GetPredefinedUpgrades(StageBossChestUpgradeRound upgradeRound, int count)
		{
			return null;
		}

		private List<BaseGameplayUpgrade> GetRandomFromCollection(int count)
		{
			return null;
		}
	}
}
