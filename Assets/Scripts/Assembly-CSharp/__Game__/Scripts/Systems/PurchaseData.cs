using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "PurchaseData", menuName = "TapHub/Shop/Purchase/Purchase Data")]
	public class PurchaseData : ScriptableObject
	{
		[SerializeField]
		private string _guid;

		[Header("Purchase Settings")]
		[SerializeField]
		private PriceType _priceType;

		[SerializeField]
		private InventoryItemData _priceItemData;

		[SerializeField]
		private int _priceItemAmount;

		[SerializeField]
		private bool _displayCurrencyAmount;

		[SerializeField]
		private ProductData _productData;

		[SerializeField]
		private TimeData _cooldownTime;

		[SerializeField]
		[Min(1f)]
		private int _availableAmount;

		[SerializeField]
		private int _maxPurchases;

		[SerializeField]
		private ShopSlotData _shopSlotData;

		[Header("Analytics")]
		[SerializeField]
		private string _placement;

		[Header("Reward Settings")]
		[SerializeField]
		private PurchaseRewardType _rewardType;

		[SerializeField]
		private RewardDisplayMode _rewardDisplayMode;

		[SerializeField]
		private List<RewardData> _rewards;

		[SerializeField]
		private ChestDataAmount _chestDataAmount;

		public string Guid => null;

		public PriceType PriceType => default(PriceType);

		public InventoryItemData PriceItemData => null;

		public bool DisplayCurrencyAmount => false;

		public int PriceItemAmount => 0;

		public string ProductId => null;

		public TimeData CooldownTime => default(TimeData);

		public int AvailableAmount => 0;

		public int MaxPurchases => 0;

		public bool HasMaxPurchases => false;

		public ShopSlotData ShopSlotData => null;

		public string Placement => null;

		public RewardDisplayMode RewardDisplayMode => default(RewardDisplayMode);

		public PurchaseRewardType RewardType => default(PurchaseRewardType);

		public List<Reward> Rewards => null;

		public ChestDataAmount Chest => null;

		private bool HasCooldown()
		{
			return false;
		}

		private bool IsCurrency()
		{
			return false;
		}

		private bool IsIAP()
		{
			return false;
		}

		private bool IsInventoryItem()
		{
			return false;
		}

		private bool IsChest()
		{
			return false;
		}
	}
}
