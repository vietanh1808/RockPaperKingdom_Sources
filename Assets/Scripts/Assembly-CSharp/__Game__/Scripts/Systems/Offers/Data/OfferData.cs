using UnityEngine;

namespace __Game__.Scripts.Systems.Offers.Data
{
	[CreateAssetMenu(fileName = "OfferData", menuName = "TapHub/Offers/Offer Data")]
	public class OfferData : ScriptableObject
	{
		[SerializeField]
		private string _guid;

		[Header("Purchase")]
		[SerializeField]
		private PurchaseData _purchaseData;

		[Header("Trigger")]
		[SerializeField]
		private OfferTriggerType _triggerType;

		[SerializeField]
		[Min(1f)]
		private int _requiredInterstitials;

		[SerializeField]
		private bool _showOnFirstEligibility;

		[Header("Persistence")]
		[SerializeField]
		private OfferPersistence _persistence;

		[Header("Eligibility")]
		[SerializeField]
		[Min(1f)]
		private int _minStage;

		[SerializeField]
		[Min(1f)]
		private int _minPlayerLevel;

		[SerializeField]
		[Min(0f)]
		private int _minDaysSinceInstall;

		[Header("Inventory Condition")]
		[SerializeField]
		private InventoryItemData _disabledByInventoryItem;

		[Header("Queue")]
		[SerializeField]
		private EventPriority _priority;

		public string Guid => null;

		public PurchaseData PurchaseData => null;

		public OfferTriggerType TriggerType => default(OfferTriggerType);

		public int RequiredInterstitials => 0;

		public bool ShowOnFirstEligibility => false;

		public int MinStage => 0;

		public int MinPlayerLevel => 0;

		public int MinDaysSinceInstall => 0;

		public OfferPersistence Persistence => default(OfferPersistence);

		public InventoryItemData DisabledByInventoryItem => null;

		public bool HasInventoryItemCondition => false;

		public EventPriority Priority => default(EventPriority);

		private bool IsTriggerNone()
		{
			return false;
		}

		private bool IsAfterInterstitials()
		{
			return false;
		}
	}
}
