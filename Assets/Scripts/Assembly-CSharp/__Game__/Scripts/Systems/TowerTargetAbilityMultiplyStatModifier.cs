using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_TowerTargetAbility_Multiply", menuName = "TapHub/Stats/Modifiers/Tower Target Ability Multiply Stat")]
	public class TowerTargetAbilityMultiplyStatModifier : BaseModifier
	{
		[SerializeField]
		private TowerData _towerData;

		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _percentageRise;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
