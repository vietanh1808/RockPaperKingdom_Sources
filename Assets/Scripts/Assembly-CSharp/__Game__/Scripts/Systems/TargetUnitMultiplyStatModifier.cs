using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_TargetUnit_Multiply", menuName = "TapHub/Stats/Modifiers/Target Unit Multiply Stat")]
	public class TargetUnitMultiplyStatModifier : BaseModifier
	{
		[SerializeField]
		private UnitData _unitData;

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
