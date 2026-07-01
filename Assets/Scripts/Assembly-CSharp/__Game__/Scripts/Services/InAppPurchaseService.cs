using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LionStudios.Suite.Purchasing;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Services
{
	public class InAppPurchaseService : IDetailedStoreListener, IStoreListener
	{
		private const float DEBUG_PURCHASE_AMOUNT = 3.99f;

		private readonly ProductCollection _productCollection;

		private readonly UIPurchaseOverlay _uiPurchaseOverlay;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly StageSystem _stageSystem;

		private readonly IAPPurchaseRestorer _purchaseRestorer;

		private IStoreController _storeController;

		private int _debugPurchaseCounter;

		private Action<bool> _onPurchaseCompleted;

		private List<Reward> _currentRewards;

		private bool _isRestorePurchase;

		public bool IsInitialized => false;

		public event Action OnStatusChanged
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

		public InAppPurchaseService(ProductCollection productCollection, UIProjectHolder uiProjectHolder, LionAnalyticsEvents lionAnalyticsEvents, StageSystem stageSystem, IAPPurchaseRestorer purchaseRestorer)
		{
		}

		public void Initialize()
		{
		}

		public void Purchase(string productID, List<Reward> rewards, Action<bool> onCompleted)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			return default(PurchaseProcessingResult);
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		public string GetLocalizedPrice(string productID)
		{
			return null;
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		private void InvokePurchaseCompleted(bool status)
		{
		}

		private void TrackInAppPurchase(Product product)
		{
		}

		private IAPGameplayInfo BuildGameplayInfo(List<Reward> rewards)
		{
			return null;
		}
	}
}
