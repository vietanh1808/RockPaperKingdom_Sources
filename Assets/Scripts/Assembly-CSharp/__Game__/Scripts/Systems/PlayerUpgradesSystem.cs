using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class PlayerUpgradesSystem
	{
		private readonly PlayerUpgradesConfig _playerUpgradesConfig;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly InventorySystem _inventorySystem;

		private InventoryItem _currencyItem;

		private bool _canUpgrade;

		private List<BaseModifier> OverrideModifiers { get; }

		public List<BaseModifier> UnlockedModifiers { get; }

		public bool CanUpgrade
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public int UnlockedUpgradeIndex { get; private set; }

		public int AvailableUpgradeIndex { get; private set; }

		public PlayerUpgradeData AvailableUpgradeData => null;

		private bool IsMaxUpgraded => false;

		public event Action OnUpgradeIndexChanged
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

		public event Action OnCanUpgradeChanged
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

		public PlayerUpgradesSystem(PlayerUpgradesConfig playerUpgradesConfig, PlayerLevelSystem playerLevelSystem, InventorySystem inventorySystem)
		{
		}

		public void LoadData(int availableUpgradeIndex)
		{
		}

		public void Initialize()
		{
		}

		public void OverrideUpgradeIndex(int upgradeIndex)
		{
		}

		public void Upgrade()
		{
		}

		public List<BaseModifier> GetUnlockedModifiers()
		{
			return null;
		}

		private void SetupAvailableUpgrade()
		{
		}

		private void SetupMaxUpgraded()
		{
		}

		private void CheckCanUpgrade()
		{
		}

		private void OnLevelChanged()
		{
		}

		private void OnCurrencyAmountChanged(InventoryItem inventoryItem)
		{
		}

		private int GetPlayerUnlockedUpgradeIndex()
		{
			return 0;
		}
	}
}
