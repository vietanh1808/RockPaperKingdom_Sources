using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityOwner
	{
		public Transform Transform { get; }

		public Transform WeaponTransform { get; }

		public BaseTargetHolder TargetHolder { get; }

		public IDamageable Damageable { get; }

		public IAbilityOwnerAnimation Animation { get; }

		public StatValue Damage { get; }

		public UnitRepository EnemyRepository { get; }

		public UnitType Side { get; }

		public AbilityOwner(Transform transform, Transform weaponTransform, BaseTargetHolder targetHolder, IDamageable damageable, IAbilityOwnerAnimation animation, StatValue damage, UnitRepository enemyRepository, UnitType side)
		{
		}
	}
}
