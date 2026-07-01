using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.Boss;
using __Game__.Scripts.Gameplay.BossChest.UI;
using __Game__.Scripts.Gameplay.EnemyHint;
using __Game__.Scripts.Gameplay.EnemyHint.UI;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.Revive.UI;
using __Game__.Scripts.Gameplay.RockPaperScissors;
using __Game__.Scripts.Gameplay.UI;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIGameplaySceneNavigation : UIBaseSceneNavigation
	{
		[Header("Panels")]
		[SerializeField]
		private UIGameplayPanel _uiGameplayPanel;

		[SerializeField]
		private UIUpgradesPanel _uiUpgradesPanel;

		[SerializeField]
		private UIBossChestUpgradesPanel _uiBossChestUpgradesPanel;

		[SerializeField]
		private UIBuildingPlacementPanel _uiBuildingPlacementPanel;

		[SerializeField]
		private UIMysteryCardShopPanel _uiMysteryCardShopPanel;

		[Header("Popups")]
		[SerializeField]
		private UIGameplayEndPopup _uiGameplayEndPopup;

		[SerializeField]
		private UIFortuneWheelPopup _uiFortuneWheelPopup;

		[SerializeField]
		private UIGameplaySettingsPopup _uiGameplaySettingsPopup;

		[SerializeField]
		private UIRestoreGameplayProgressPopup _uiRestoreGameplayProgressPopup;

		[SerializeField]
		private UIRockPaperScissorsPanel _uiRockPaperScissorsPanel;

		[SerializeField]
		private UIEnemyHintPopup _uiEnemyHintPopup;

		[SerializeField]
		private UIRevivePopup _uiRevivePopup;

		[Header("Other")]
		[SerializeField]
		private UIWaveAlertMessage _uiWaveAlertMessage;

		[SerializeField]
		private UIRoundAnnouncer _uiRoundAnnouncer;

		[SerializeField]
		private UIBossHealthPoints _uiBossHealthPoints;

		[SerializeField]
		private UICardHandHolder _uiCardHandHolder;

		[SerializeField]
		private UIRockPaperScissorsButton _uiRockPaperScissorsButton;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		public UIGameplayPanel UIGameplayPanel => null;

		public UIUpgradesPanel UIUpgradesPanel => null;

		public UIBuildingPlacementPanel UIBuildingPlacementPanel => null;

		public UIBossChestUpgradesPanel UIBossChestUpgradesPanel => null;

		public UIFortuneWheelPopup UIFortuneWheelPopup => null;

		public UICardHandHolder UICardHandHolder => null;

		public UIRockPaperScissorsButton UIRockPaperScissorsButton => null;

		public UIRockPaperScissorsPanel UIRockPaperScissorsPanel => null;

		[Inject]
		private void Inject(LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void Start()
		{
		}

		public void OpenUpgradesPanel(Action onClosed)
		{
		}

		public void OpenBossChestUpgradesPanel(List<BaseGameplayUpgrade> upgrades, Action<BaseGameplayUpgrade> onUpgradeSelected, Action onClosed)
		{
		}

		public void OpenFortuneWheelPopup()
		{
		}

		public void OpenVictoryPopup(int selectedStageIndex)
		{
		}

		public void OpenDefeatPopup(int selectedStageIndex)
		{
		}

		public void OpenRevivePopup(Action onRevive, Action onDecline)
		{
		}

		public void OpenSettingsPopup()
		{
		}

		public void OpenRestoreGameplayPopup(Action onContinueHandler, Action onQuitHandler)
		{
		}

		public void ShowAlert(AlertData alertData)
		{
		}

		public void ShowRoundAnnouncement(int roundNumber)
		{
		}

		public void ShowBossHealth(UnitHealthPoints unitHealthPoints)
		{
		}

		public void HideBossHealth()
		{
		}

		public void ShowCardHandHolder(bool isShow)
		{
		}

		public void ShowBuildingPlacementPanel(bool isShow)
		{
		}

		public void OpenRockPaperScissorsPanel()
		{
		}

		public void OpenMysteryCardShopPanel(Action onClosed = null)
		{
		}

		public void ShowEnemyHintPopup(EnemyHintEntry entry)
		{
		}

		public void HideEnemyHintPopup()
		{
		}
	}
}
