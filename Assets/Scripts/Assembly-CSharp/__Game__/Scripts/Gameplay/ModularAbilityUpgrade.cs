using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Upgrade_", menuName = "TapHub/Ability/Upgrades/Ability Modular Upgrade")]
	public class ModularAbilityUpgrade : BaseAbilityUpgrade
	{
		[SerializeField]
		private AbilityData _targetAbilityData;

		[SerializeField]
		private UnitData _targetUnitData;

		[SerializeField]
		private AssetModuleHolder<BaseAbilityUpgradeModule> _upgradeModuleHolder;

		private void OnEnable()
		{
		}

		public override void Apply(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
		}

		private SharedAbility GetAbilityRuntimeData(SharedUnit sharedUnit)
		{
			return null;
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
