using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_Tower_Add", menuName = "TapHub/Stats/Modifiers/Tower Add Stat")]
	public class TowerAddStatModifier : BaseModifier
	{
		[SerializeField]
		private TowerData _towerData;

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
