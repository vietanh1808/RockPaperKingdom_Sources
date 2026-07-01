using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.MysteryCardShop;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingPlacementPanel : MonoBehaviour
	{
		[SerializeField]
		private GameObject _buttonsContainer;

		[SerializeField]
		private UIButtonClick _fightButton;

		[SerializeField]
		private UIBuildingInfoView _statsView;

		[SerializeField]
		private UIBuildingPlacementCardsCounter _cardsCounter;

		[SerializeField]
		private UIGridExpandButton _expandButton;

		[SerializeField]
		private UIMysteryCardShopButton _shopButton;

		[SerializeField]
		private GameObject _sellButton;

		[SerializeField]
		private GameObject _rpsButton;

		private BuildingPlacementStateTracker _stateTracker;

		private GameplayConfig _gameplayConfig;

		private WaveSystem _waveSystem;

		private GridExpandSystem _gridExpandSystem;

		private GameplayInventorySystem _gameplayInventorySystem;

		private UIGameplaySceneNavigation _uiGameplaySceneNavigation;

		private BuildingHoverController _hoverController;

		private PlayerGameplayProgressService _progressService;

		private FirstWaveFightButtonTracker _firstWaveFightButtonTracker;

		private InventoryItem _expandItem;

		private InventoryItem _gameplayCardItem;

		public event Action OnFightButtonClicked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		public void Inject(BuildingPlacementStateTracker stateTracker, GameplayConfig gameplayConfig, WaveSystem waveSystem, GridExpandSystem gridExpandSystem, GameplayInventorySystem gameplayInventorySystem, UIGameplaySceneNavigation uiGameplaySceneNavigation, BuildingHoverController hoverController, PlayerGameplayProgressService progressService, FirstWaveFightButtonTracker firstWaveFightButtonTracker)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnFightButtonClick()
		{
		}

		private void OnPlacementStateChanged(BuildingInfoStatus state)
		{
		}

		private void OnHoverStateChanged()
		{
		}

		private void OnExpandItemAmountChanged(InventoryItem item)
		{
		}

		private void SubscribeToExpandItem()
		{
		}

		private void UnsubscribeFromExpandItem()
		{
		}

		private void UpdateButtonsContainerVisibility()
		{
		}

		private void UpdateCardsCounterVisibility()
		{
		}

		private void UpdateExpandButtonVisibility()
		{
		}

		private void OnMysteryShopCardItemAmountChanged(InventoryItem item)
		{
		}

		private void SubscribeToMysteryShopCardItem()
		{
		}

		private void UnsubscribeFromMysteryShopCardItem()
		{
		}

		private void UpdateShopButtonVisibility()
		{
		}

		private void OnRpsAvailabilityChanged()
		{
		}

		private void UpdateRpsButtonsVisibility()
		{
		}

		private void OnExpandModeChanged()
		{
		}
	}
}
