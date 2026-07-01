using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class TowerBuildingAnimation : MonoBehaviour, IAbilityOwnerAnimation
	{
		private static readonly int PREPARING_ATTACK;

		private static readonly int EXECUTING_ATTACK;

		[SerializeField]
		private Animator _animator;

		public void SetPreparingCastStatus(bool isPreparingCast)
		{
		}

		public void TriggerCast()
		{
		}
	}
}
