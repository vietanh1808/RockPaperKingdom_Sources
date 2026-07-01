using DG.Tweening;
using __Game__.Scripts.Gameplay.Coins;
using __Game__.Scripts.Gameplay.Experience;

namespace __Game__.Scripts.Gameplay.StateMachine.States
{
	public class ExperienceCollectionState : BaseGameplayState
	{
		private const float COIN_COLLECTION_DELAY = 0.5f;

		private readonly ExperienceObjectManager _experienceObjectManager;

		private readonly GameplayCoinObjectManager _coinObjectManager;

		private bool _experienceCollected;

		private bool _coinsCollected;

		private Tween _coinCollectionDelayTween;

		public ExperienceCollectionState(ExperienceObjectManager experienceObjectManager, GameplayCoinObjectManager coinObjectManager)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		private void OnAllExperienceCollected()
		{
		}

		private void OnAllCoinsCollected()
		{
		}

		private void TryTransition()
		{
		}
	}
}
