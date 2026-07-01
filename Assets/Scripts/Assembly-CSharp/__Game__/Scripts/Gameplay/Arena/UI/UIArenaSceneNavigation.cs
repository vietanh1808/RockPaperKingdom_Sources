using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.UI;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaSceneNavigation : UIBaseSceneNavigation
	{
		[Header("Panels")]
		[SerializeField]
		private UIArenaGameplayPanel _uiArenaGameplayPanel;

		[SerializeField]
		private UIArenaUpgradesPanel _uiArenaUpgradesPanel;

		[SerializeField]
		private UIArenaBuildingPlacementPanel _uiArenaBuildingPlacementPanel;

		[SerializeField]
		private UIArenaEndPanel _uiArenaEndPanel;

		[Header("Popups")]
		[SerializeField]
		private UIGameplaySettingsPopup _uiGameplaySettingsPopup;

		[Header("Other")]
		[SerializeField]
		private UICardHandHolder _uiCardHandHolder;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		public UIArenaGameplayPanel UIArenaGameplayPanel => null;

		public UIArenaUpgradesPanel UIArenaUpgradesPanel => null;

		public UIArenaBuildingPlacementPanel UIArenaBuildingPlacementPanel => null;

		public UICardHandHolder UICardHandHolder => null;

		[Inject]
		private void Inject(LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		public void OpenUpgradesPanel(Action onClosed)
		{
		}

		public void OpenArenaEndPanel(ArenaMatchOutcome outcome, ArenaMatchResult matchResult, Action onContinue)
		{
		}

		public void ShowCardHandHolder(bool isShow)
		{
		}

		public void ShowBuildingPlacementPanel(bool isShow)
		{
		}

		public void OpenSettingsPopup()
		{
		}
	}
}
