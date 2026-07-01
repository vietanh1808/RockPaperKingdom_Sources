using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_AddSecondaryAbility", menuName = "TapHub/Ability/Upgrades/Add Secondary Ability Upgrade")]
	public class AddSecondaryAbilityUpgrade : BaseAbilityUpgrade
	{
		[SerializeField]
		private UnitData _targetUnitData;

		[SerializeField]
		private AbilityData _secondaryAbilityData;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		public override UnitData GetTargetUnitData()
		{
			return null;
		}
	}
}
