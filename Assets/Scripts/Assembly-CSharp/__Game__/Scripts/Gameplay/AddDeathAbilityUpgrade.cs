using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_AddDeathAbility", menuName = "TapHub/Ability/Upgrades/Add Death Ability Upgrade")]
	public class AddDeathAbilityUpgrade : BaseAbilityUpgrade
	{
		[SerializeField]
		private UnitData _targetUnitData;

		[SerializeField]
		private AbilityData _targetAbilityData;

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		public override UnitData GetTargetUnitData()
		{
			return null;
		}
	}
}
