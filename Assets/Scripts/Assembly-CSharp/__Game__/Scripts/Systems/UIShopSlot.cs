using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIShopSlot : UIBaseShopSlot
	{
		[SerializeField]
		private UIPurchaseButton _purchaseButton;

		[SerializeField]
		private UIRewardsView _uiRewardsView;

		[SerializeField]
		private PurchaseData _purchaseData;

		private PurchaseCountsTracker _purchaseCountsTracker;

		[Inject]
		public void Construct(PurchaseCountsTracker purchaseCountsTracker)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupSlot()
		{
		}

		private void SetupIcon()
		{
		}

		private void SetupRewards()
		{
		}

		private void InitializePurchaseButton()
		{
		}

		private void HandlePurchaseRegistered(PurchaseData purchaseData)
		{
		}

		private bool IsMaxPurchasesReached()
		{
			return false;
		}
	}
}
