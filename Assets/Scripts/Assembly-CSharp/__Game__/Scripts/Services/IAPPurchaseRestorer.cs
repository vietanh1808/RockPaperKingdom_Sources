using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services
{
	public class IAPPurchaseRestorer
	{
		private readonly PurchaseCollection _purchaseCollection;

		private readonly PurchaseCountsTracker _purchaseCountsTracker;

		private readonly RewardSystem _rewardSystem;

		private readonly ISaveLoadDataService _saveLoadDataService;

		public IAPPurchaseRestorer(PurchaseCollection purchaseCollection, PurchaseCountsTracker purchaseCountsTracker, RewardSystem rewardSystem, ISaveLoadDataService saveLoadDataService)
		{
		}

		public bool TryRestore(string productId)
		{
			return false;
		}
	}
}
