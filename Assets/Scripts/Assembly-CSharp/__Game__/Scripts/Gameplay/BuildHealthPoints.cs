using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Gameplay
{
	public class BuildHealthPoints
	{
		private Action _onDeathCallback;

		public float CurrentHealthPoints { get; private set; }

		public float CurrentHealthPercent => 0f;

		public float MaxHealthPoints { get; private set; }

		public float Armor { get; private set; }

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

		public event Action OnDeath
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

		public void Initialize(float maxHealth, Action onDeath)
		{
		}

		public void Reset()
		{
		}

		public void RestoreToMax()
		{
		}

		public void SetMaxHealth(float newMaxHealth)
		{
		}

		public void SetArmor(float armor)
		{
		}

		public void TakeDamage(Damage damage)
		{
		}

		public void RestoreHealth(float currentHealth)
		{
		}
	}
}
