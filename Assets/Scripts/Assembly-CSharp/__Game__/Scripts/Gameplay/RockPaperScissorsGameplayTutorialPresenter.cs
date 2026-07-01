using Zenject;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class RockPaperScissorsGameplayTutorialPresenter : BaseGameplayTutorialPresenter
	{
		private PlayerGameplayProgressService _playerGameplayProgressService;

		private GameplayStateMachine _gameplayStateMachine;

		private RockPaperScissorsSystem _rockPaperScissorsSystem;

		[Inject]
		private void Inject(PlayerGameplayProgressService playerGameplayProgressService, GameplayStateMachine gameplayStateMachine, RockPaperScissorsSystem rockPaperScissorsSystem)
		{
		}

		public override void Initialize()
		{
		}

		private void OnRpsAvailabilityChanged()
		{
		}

		private void OnStateEntered(BaseGameplayState state)
		{
		}

		private bool TryStartTutorial()
		{
			return false;
		}
	}
}
