using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_", menuName = "TapHub/Ability/Upgrades/Bundle Modular Upgrade")]
	public class BundleAbilityUpgrade : BaseAbilityUpgrade
	{
		[SerializeField]
		private List<BaseGameplayUpgrade> _abilityUpgrades;

		[SerializeField]
		private UnitData _targetUnitData;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		public override UnitData GetTargetUnitData()
		{
			return null;
		}

		public override string[] GetDescription()
		{
			return null;
		}
	}
}
