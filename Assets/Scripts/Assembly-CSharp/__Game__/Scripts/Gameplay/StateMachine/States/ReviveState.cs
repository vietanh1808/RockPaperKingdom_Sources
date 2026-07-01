using __Game__.Scripts.Gameplay.Revive;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class ReviveState : BaseGameplayState
	{
		private readonly UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private readonly ReviveSystem _reviveSystem;

		public ReviveState(UIGameplaySceneNavigation uiGameplaySceneNavigation, ReviveSystem reviveSystem)
		{
		}

		public override void Enter()
		{
		}

		private void OnRevive()
		{
		}

		private void OnDecline()
		{
		}
	}
}
