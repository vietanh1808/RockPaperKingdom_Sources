using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UnitAnimation : IAbilityOwnerAnimation
	{
		private static readonly int IS_MOVING;

		private static readonly int PREPARING_ATTACK;

		private static readonly int EXECUTING_ATTACK;

		private static readonly int TAKE_DAMAGE;

		private static readonly int DIE;

		private static readonly int CYCLE_OFFSET;

		private Animator _animator;

		private bool _isPaused;

		public void Initialize(Animator animator)
		{
		}

		public void Reset()
		{
		}

		public void SetMoving(bool isMoving)
		{
		}

		public void SetPreparingCastStatus(bool isPreparingCast)
		{
		}

		public void TriggerCast()
		{
		}

		public void PlayTakeDamage()
		{
		}

		public void PlayDie()
		{
		}

		public void Pause(bool isPaused)
		{
		}
	}
}
