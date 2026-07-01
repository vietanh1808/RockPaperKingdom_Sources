using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class UITalentCollectionMenuTutorial : UIBaseMenuTutorial
	{
		[Header("Step 1")]
		[SerializeField]
		private RectTransform _talentNavigationButtonContainer;

		[Header("Step 2")]
		[SerializeField]
		private UITalentCollectionPanel _uiTalentCollectionPanel;

		[Header("Step 3")]
		[SerializeField]
		private RectTransform _drawButtonContainer;

		private TalentCollectionSystem _talentCollectionSystem;

		private InventorySystem _inventorySystem;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		[Inject]
		private void Inject(TalentCollectionSystem talentCollectionSystem, InventorySystem inventorySystem, GameAnalyticsEvents gameAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void StartTutorial(Action onTutorialFinished)
		{
		}

		private void OnTalentElementsCreated()
		{
		}

		private void OnTalentDrawStarted()
		{
		}

		private void ValidateRequiredResources()
		{
		}

		private void EnsureResourceAvailable(PriceData priceData)
		{
		}
	}
}
