using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class Ability
	{
		private readonly AbilityStateMachine _abilityStateMachine;

		private readonly AbilityDamageApplier _abilityDamageApplier;

		public AbilityData Data { get; }

		public SharedAbility Shared { get; }

		public AbilityCooldown Cooldown { get; }

		public AbilityOwner Owner { get; }

		public AbilityModuleHolder Modules { get; }

		public Ability CastOnHit { get; set; }

		public int ReleaseIndex { get; set; }

		public Vector3 CurrentPosition { get; private set; }

		public IDamageable TargetIgnore { get; private set; }

		public event Action OnCastStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnCastEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnDeactivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Ability(AbilityData abilityData, SharedAbility shared, AbilityOwner owner, AbilityModuleHolder modules)
		{
		}

		public void Tick()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void ApplyDamage(IDamageable target)
		{
		}

		public void InvokeCastStart()
		{
		}

		public void InvokeCastEnd()
		{
		}

		private void ApplyDebuffs(IDamageable damageable)
		{
		}

		private void ApplyCastOnHit(IDamageable damageable)
		{
		}

		private void InvokeCast()
		{
		}
	}
}
