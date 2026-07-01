using System;
using System.Runtime.CompilerServices;
using Zenject;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityCooldown : ITickable
	{
		private const float RESET_COOLDOWN_PENDING_DURATION = 1f;

		public const float MAX_ATTACK_SPEED = 10f;

		private readonly StatValue _attackSpeedValueStat;

		public float CooldownTime { get; private set; }

		public event Action OnCooldownChanged
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

		public event Action OnCooldownFinished
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

		public AbilityCooldown(Ability ability)
		{
		}

		public void Tick()
		{
		}

		public void OverrideCooldownTime(float overrideTime)
		{
		}

		public void Reset()
		{
		}

		public void ResetIfPendingDuration(float stateDuration)
		{
		}
	}
}
