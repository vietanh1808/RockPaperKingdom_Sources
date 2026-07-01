using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public static class AbilityTargetUtility
	{
		public static IDamageable GetDamageable(Collider collider, Ability ability)
		{
			return null;
		}

		public static IDamageable GetTarget(Collider collider, Ability ability)
		{
			return null;
		}

		public static BaseUnit GetUnit(IDamageable target)
		{
			return null;
		}

		public static BaseUnit GetUnit(IDebuffable target)
		{
			return null;
		}
	}
}
