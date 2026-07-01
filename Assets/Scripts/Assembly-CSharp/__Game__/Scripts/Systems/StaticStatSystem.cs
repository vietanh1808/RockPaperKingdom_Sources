using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class StaticStatSystem
	{
		private readonly PlayerUpgradesSystem _playerUpgradesSystem;

		private readonly EquipmentSystem _equipmentSystem;

		private readonly HeroSystem _heroSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly TalentCollectionSystem _talentCollectionSystem;

		public PlayerStaticStatsRepository PlayerStats { get; }

		public UnitStaticStatsRepository UnitStats { get; }

		public AbilityStaticStatsRepository AbilityStats { get; }

		public TowerStaticStatsRepository TowerStats { get; }

		private List<BaseModifier> StatModifiers { get; }

		public event Action OnRefreshed
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

		public StaticStatSystem(PlayerUpgradesSystem playerUpgradesSystem, EquipmentSystem equipmentSystem, HeroSystem heroSystem, UnitCardSystem unitCardSystem, TalentCollectionSystem talentCollectionSystem, PlayerStaticStatsRepository playerStats, UnitStaticStatsRepository unitStats, AbilityStaticStatsRepository abilityStats, TowerStaticStatsRepository towerStats)
		{
		}

		public void Initialize()
		{
		}

		private void OnHeroLevelChanged(HeroItem heroItem)
		{
		}

		private void OnUnitCardLevelChanged(UnitCardItem unitCardItem)
		{
		}

		private void OnTalentDrawCompleted(TalentRuntime talentRuntime)
		{
		}

		private void RecalculatePlayerStats()
		{
		}

		private void ResetStatsToDefaultValues()
		{
		}

		private void CollectPlayerUpgradeModifiers()
		{
		}

		private void CollectTalentModifiers()
		{
		}

		private void ApplyHeroStats()
		{
		}

		private void ApplyUnits()
		{
		}

		private void ApplyUnitCardStats(UnitCardItem unitCardItem)
		{
		}

		private void ApplyEquipment()
		{
		}

		private void ApplyModifiers()
		{
		}

		private void ApplyPlayer()
		{
		}
	}
}
