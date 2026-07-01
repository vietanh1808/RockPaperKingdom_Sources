using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UITalentCollectionPanel : MonoBehaviour
	{
		[Header("Talent Components")]
		[SerializeField]
		private RectTransform _gridContainer;

		[SerializeField]
		private UITalentUpgradeElement _uiTalentUpgradePrefab;

		[Header("Purchase Components")]
		[SerializeField]
		private UIButtonClick _drawButtonClick;

		[SerializeField]
		private Image _currencyImage;

		[SerializeField]
		private TMP_Text _amountText;

		[SerializeField]
		private Image _secondaryCurrencyImage;

		[SerializeField]
		private TMP_Text _secondaryAmountText;

		[Header("Purchase View")]
		[SerializeField]
		private Color _availablePurchaseColor;

		[SerializeField]
		private Color _unavailablePurchaseColor;

		[Header("Alert")]
		[SerializeField]
		private GameObject _alertGameObject;

		private readonly Dictionary<TalentRuntime, UITalentUpgradeElement> _uiTalentUpgradeElements;

		private TalentCollectionSystem _talentCollectionSystem;

		private TalentCanDrawTracker _talentCanDrawTracker;

		private TalentCollectionConfig _talentCollectionConfig;

		private InventorySystem _inventorySystem;

		private RarityConfig _rarityConfig;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		public event Action OnTalentElementsCreated
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

		public event Action OnTalentDrawStarted
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
		private void Inject(TalentCollectionSystem talentCollectionSystem, TalentCanDrawTracker talentCanDrawTracker, TalentCollectionConfig talentCollectionConfig, InventorySystem inventorySystem, RarityConfig rarityConfig, UIMenuSceneNavigation uiMenuSceneNavigation, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CreateTalentElement(TalentRuntime talentRuntime)
		{
		}

		private void SetupView()
		{
		}

		private void UpdatePurchaseView()
		{
		}

		private Color GetPriceColor(PriceData priceData)
		{
			return default(Color);
		}

		private void OnTalentInfoButtonClicked(TalentRuntime talentRuntime)
		{
		}

		private void OnTalentDrawButtonClicked()
		{
		}

		private void OnTalentDrawCompleted(TalentRuntime talentRuntime)
		{
		}

		private void OnTalentLandingCompleted(TalentRuntime talentRuntime)
		{
		}
	}
}
