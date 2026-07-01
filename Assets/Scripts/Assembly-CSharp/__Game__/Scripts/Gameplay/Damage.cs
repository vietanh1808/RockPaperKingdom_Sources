using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class Damage
	{
		public float FinalValue;

		public float ActualDamage;

		public float BaseValue { get; private set; }

		public Vector3 Position { get; private set; }

		public IDamageable Source { get; private set; }

		public DamageType DamageType { get; private set; }

		public RangeType RangeType { get; private set; }

		public bool HasCrit { get; private set; }

		public Damage(float baseValue, float finalValue, Vector3 position, IDamageable source = null, RangeType rangeType = RangeType.RANGE, DamageType damageType = DamageType.DEFAULT)
		{
		}

		public void AddCritStatus()
		{
		}
	}
}
