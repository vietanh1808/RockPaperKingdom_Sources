using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIUpgradesReroll : BaseUIUpgradesReroll
	{
		private GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private UIUpgradesPanel _uiUpgradesPanel;

		private StageSystem _stageSystem;

		protected override string AdsPlacementName => null;

		protected override string AnalyticsLocation => null;

		[Inject]
		private void Inject(GameplayUpgradesPresenter gameplayUpgradesPresenter, UIGameplaySceneNavigation uiGameplaySceneNavigation, StageSystem stageSystem)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void PerformReroll()
		{
		}

		private void OnUpgradeSelected()
		{
		}

		private void OnUpgradesSpawned()
		{
		}
	}
}
