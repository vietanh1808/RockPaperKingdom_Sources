using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_Unit_Multiply", menuName = "TapHub/Stats/Modifiers/Unit Multiply Stat")]
	public class UnitMultiplyStatModifier : BaseModifier
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

		public UnitStatType GetUnitStatType()
		{
			return default(UnitStatType);
		}

		public float GetValue()
		{
			return 0f;
		}
	}
}
