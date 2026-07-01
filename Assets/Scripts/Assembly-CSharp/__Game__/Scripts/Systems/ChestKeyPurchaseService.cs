using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class ChestKeyPurchaseService
	{
		private const string TRANSACTION_NAME = "purchase_chest";

		private readonly InventorySystem _inventorySystem;

		private readonly UIMenuSceneNavigation _uiMenuSceneNavigation;

		private readonly LionAnalyticsEvents _lionAnalyticsEvents;

		private readonly PurchaseCountsTracker _purchaseCountsTracker;

		public ChestKeyPurchaseService(InventorySystem inventorySystem, UIMenuSceneNavigation uiMenuSceneNavigation, LionAnalyticsEvents lionAnalyticsEvents, PurchaseCountsTracker purchaseCountsTracker)
		{
		}

		public int GetKeysOwned(PurchaseData keyPurchaseData)
		{
			return 0;
		}

		public void OpenChestsWithAllKeys(ChestData chestData, PurchaseData keyPurchaseData)
		{
		}
	}
}
