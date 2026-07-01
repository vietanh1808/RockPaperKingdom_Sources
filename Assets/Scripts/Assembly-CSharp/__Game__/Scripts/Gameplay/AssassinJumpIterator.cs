using System.Collections.Generic;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class AssassinJumpIterator : ITickable
	{
		private const float JUMP_DELAY = 1.5f;

		private readonly Queue<FurthestEnemyJump> _pendingJumps;

		private readonly HashSet<FurthestEnemyJump> _registered;

		private float _elapsedTime;

		private bool _isActive;

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void Register(FurthestEnemyJump component)
		{
		}

		public void Unregister(FurthestEnemyJump component)
		{
		}

		public void Tick()
		{
		}

		private void ProcessNextJump()
		{
		}
	}
}
