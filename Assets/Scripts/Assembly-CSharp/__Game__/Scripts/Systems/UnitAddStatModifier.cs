using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_Unit_Add", menuName = "TapHub/Stats/Modifiers/Unit Add Stat")]
	public class UnitAddStatModifier : BaseModifier
	{
		[SerializeField]
		private UnitStatType _statType;

		[SerializeField]
		private float _value;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}
	}
}
