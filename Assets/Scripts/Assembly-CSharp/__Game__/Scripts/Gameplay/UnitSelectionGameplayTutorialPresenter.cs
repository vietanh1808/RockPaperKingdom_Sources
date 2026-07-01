using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UnitSelectionGameplayTutorialPresenter : BaseGameplayTutorialPresenter
	{
		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private StageSystem _stageSystem;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation, StageSystem stageSystem)
		{
		}

		public override void Initialize()
		{
		}

		private void OnUpgradesSpawned()
		{
		}
	}
}
