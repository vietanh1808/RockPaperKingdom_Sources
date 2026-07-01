using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class ForwardMovementTargetProvider : ITargetProvider
	{
		private static readonly Vector3 PLAYER_FORWARD;

		private static readonly Vector3 ENEMY_FORWARD;

		public AbilityTargetLocation GetTargetPosition(Ability ability)
		{
			return null;
		}

		public bool HasTarget(Ability ability)
		{
			return false;
		}
	}
}
