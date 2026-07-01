using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaBuildingPlacementPanel : MonoBehaviour
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
		private GameObject _sellButton;

		private BuildingPlacementStateTracker _stateTracker;

		private GridExpandSystem _gridExpandSystem;

		private GameplayInventorySystem _gameplayInventorySystem;

		private UIArenaSceneNavigation _uiArenaSceneNavigation;

		private BuildingHoverController _hoverController;

		private InventoryItem _expandItem;

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
		public void Inject(BuildingPlacementStateTracker stateTracker, GridExpandSystem gridExpandSystem, GameplayInventorySystem gameplayInventorySystem, UIArenaSceneNavigation uiArenaSceneNavigation, BuildingHoverController hoverController)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
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

		private void OnFightButtonClick()
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

		private void UpdateSellButtonVisibility()
		{
		}

		private void OnExpandModeChanged()
		{
		}
	}
}
