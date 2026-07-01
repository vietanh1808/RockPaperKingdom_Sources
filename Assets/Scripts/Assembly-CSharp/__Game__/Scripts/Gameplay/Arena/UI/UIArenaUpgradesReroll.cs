using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaUpgradesReroll : BaseUIUpgradesReroll
	{
		private ArenaUpgradesPresenter _arenaUpgradesPresenter;

		private UIArenaUpgradesPanel _uiArenaUpgradesPanel;

		protected override string AdsPlacementName => null;

		protected override string AnalyticsLocation => null;

		[Inject]
		private void Inject(ArenaUpgradesPresenter arenaUpgradesPresenter, UIArenaSceneNavigation uiArenaSceneNavigation)
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
