using System;
using System.Collections.Generic;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class PurchaseSystem : IInitializable, IDisposable
	{
		private readonly Dictionary<string, BasePurchaseProvider> _purchaseProviders;

		private readonly PurchaseCollection _purchaseCollection;

		private readonly CooldownSystem _cooldownSystem;

		private readonly PurchaseProviderFactory _purchaseProviderFactory;

		private readonly RewardSystem _rewardSystem;

		private readonly UIMenuSceneNavigation _uiMenuSceneNavigation;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly PurchaseCountsTracker _purchaseCountsTracker;

		public PurchaseSystem(PurchaseCollection purchaseCollection, CooldownSystem cooldownSystem, PurchaseProviderFactory purchaseProviderFactory, RewardSystem rewardSystem, UIMenuSceneNavigation uiMenuSceneNavigation, LionAnalyticsEvents lionAnalyticsEvents, PurchaseCountsTracker purchaseCountsTracker)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private BasePurchaseProvider CreatePurchaseProvider(PurchaseData purchaseData)
		{
			return null;
		}

		public void CompletePurchase(BasePurchaseProvider purchaseProvider)
		{
		}

		public BasePurchaseProvider GetPurchaseProvider(PurchaseData purchaseData)
		{
			return null;
		}

		private void ClaimReward(BasePurchaseProvider purchaseProvider)
		{
		}
	}
}
