using System;
using System.Collections.Generic;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems.Offers.Data;

namespace __Game__.Scripts.Systems.Offers
{
	public class OfferSystem : IDisposable
	{
		private readonly StageSystem _stageSystem;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly PlayerInstallTracker _playerInstallTracker;

		private readonly PurchaseCountsTracker _purchaseCountsTracker;

		private readonly InterstitialAdTracker _interstitialAdTracker;

		private readonly InventorySystem _inventorySystem;

		private readonly Dictionary<OfferData, Offer> _offers;

		private Dictionary<string, OfferState> _savedStates;

		private readonly HashSet<string> _triggeredThisSession;

		private bool _hasLaunchedMenuThisSession;

		private bool _isCurrentMenuLaunchFirst;

		public IReadOnlyDictionary<OfferData, Offer> Offers => null;

		public OfferSystem(StageSystem stageSystem, PlayerLevelSystem playerLevelSystem, PlayerInstallTracker playerInstallTracker, PurchaseCountsTracker purchaseCountsTracker, InterstitialAdTracker interstitialAdTracker, InventorySystem inventorySystem)
		{
		}

		public void Dispose()
		{
		}

		public void LoadData(Dictionary<string, OfferState> offerStates)
		{
		}

		public Dictionary<string, OfferState> GetSaveData()
		{
			return null;
		}

		public Offer GetOffer(OfferData offerData)
		{
			return null;
		}

		public void RegisterMenuLaunch()
		{
		}

		public bool IsEligible(Offer offer, PurchaseSystem purchaseSystem)
		{
			return false;
		}

		public void MarkShown(Offer offer)
		{
		}

		public bool AreConditionsMet(Offer offer, PurchaseSystem purchaseSystem)
		{
			return false;
		}

		private bool OwnsInventoryConditionItem(OfferData offerData)
		{
			return false;
		}

		private void HandlePurchaseRegistered(PurchaseData purchaseData)
		{
		}

		private bool IsTriggerSatisfied(Offer offer)
		{
			return false;
		}

		private bool HasReachedRequiredInterstitials(Offer offer)
		{
			return false;
		}

		private bool IsPersistenceSatisfied(Offer offer)
		{
			return false;
		}

		private bool IsPurchaseAvailable(OfferData offerData, PurchaseSystem purchaseSystem)
		{
			return false;
		}
	}
}
