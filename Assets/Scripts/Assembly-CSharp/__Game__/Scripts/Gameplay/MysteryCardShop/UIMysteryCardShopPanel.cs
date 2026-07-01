using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.MysteryCardShop
{
	public class UIMysteryCardShopPanel : MonoBehaviour
	{
		[SerializeField]
		private UIMysteryCardShopItem _itemPrefab;

		[SerializeField]
		private List<RectTransform> _cardContainers;

		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private TMP_Text _tipText;

		private DiContainer _diContainer;

		private MysteryCardShopSystem _mysteryCardShopSystem;

		private IAdsService _adsService;

		private GameplayInventorySystem _gameplayInventorySystem;

		private GameplayConfig _gameplayConfig;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Action _onClosedCallback;

		private InventoryItem _currencyItem;

		private bool _rvUsed;

		private readonly List<UIMysteryCardShopItem> _cardItems;

		[Inject]
		private void Inject(DiContainer diContainer, MysteryCardShopSystem mysteryCardShopSystem, IAdsService adsService, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open(Action onClosed)
		{
		}

		public void Close()
		{
		}

		private void SubscribeToShopEvents()
		{
		}

		private void UnsubscribeFromShopEvents()
		{
		}

		private void CreateAllItems()
		{
		}

		private void DestroyAllItems()
		{
		}

		private void HandleItemClicked(UIMysteryCardShopItem item)
		{
		}

		private void HandleItemRvRewardReceived(UIMysteryCardShopItem item)
		{
		}

		private void HandleItemRevealFinished(UIMysteryCardShopItem item)
		{
		}

		private void HandleCardPurchased(int index)
		{
		}

		private void HandleCurrencyAmountChanged(InventoryItem item)
		{
		}

		private void RefreshAllItems()
		{
		}

		private void EnableRvModeOnAllCards()
		{
		}

		private void DisableRvModeOnAllCards()
		{
		}

		private void StopWobbleOnAllCards()
		{
		}

		private void UpdateCloseButtonVisibility()
		{
		}

		private void UpdateTipTextVisibility()
		{
		}
	}
}
