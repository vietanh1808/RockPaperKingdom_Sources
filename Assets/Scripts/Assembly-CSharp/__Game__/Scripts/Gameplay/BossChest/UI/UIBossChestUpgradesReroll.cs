using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.BossChest.UI
{
	public class UIBossChestUpgradesReroll : BaseUIUpgradesReroll
	{
		private UIBossChestUpgradesPanel _uiBossChestUpgradesPanel;

		protected override string AdsPlacementName => null;

		protected override string AnalyticsLocation => null;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation)
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
	}
}
