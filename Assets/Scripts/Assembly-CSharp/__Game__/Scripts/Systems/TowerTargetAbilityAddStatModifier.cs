using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_TowerTargetAbility_Add", menuName = "TapHub/Stats/Modifiers/Tower Target Ability Add Stat")]
	public class TowerTargetAbilityAddStatModifier : BaseModifier
	{
		[SerializeField]
		private TowerData _towerData;

		[SerializeField]
		private AbilityStatType _statType;

		[SerializeField]
		private float _additionalValue;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
