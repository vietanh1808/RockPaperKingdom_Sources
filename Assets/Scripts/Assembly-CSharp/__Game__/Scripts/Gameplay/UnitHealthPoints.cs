using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class UnitHealthPoints
	{
		private Action _onDeath;

		private BaseUnit _unit;

		private StatValue _healthPointsStat;

		private StatValue _rangeDamageReductionPercent;

		private StatValue _regenerationStat;

		private float _healthMultiplier;

		public float CurrentHealthPoints { get; private set; }

		public float ExtraDamageMultiplier { get; set; }

		public float CurrentHealthPercent => 0f;

		public float MaxHealthPoints => 0f;

		public bool IsDead => false;

		public event Action<Damage> OnDamageReceived
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

		public event Action<float> OnHealthPointsChanged
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

		public void Initialize(BaseUnit unit, StatValue healthPoints, Action onDeath)
		{
		}

		public void Reset()
		{
		}

		public void Tick()
		{
		}

		public void ApplyMultiplier(float multiplier)
		{
		}

		public void Heal(float value)
		{
		}

		public void ForceKill()
		{
		}

		public void TakeDamage(Damage damage)
		{
		}

		private void ReduceRangeDamage(Damage damage)
		{
		}

		private void AddExtraDamage(Damage damage)
		{
		}

		private void OnHealthPointsStatChanged(StatValue statValue)
		{
		}
	}
}
