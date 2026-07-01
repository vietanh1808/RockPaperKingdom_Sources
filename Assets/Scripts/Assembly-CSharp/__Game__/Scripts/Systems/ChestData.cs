using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "ChestData", menuName = "TapHub/Shop/Chests/ChestData")]
	public class ChestData : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private string _title;

		[SerializeField]
		private Sprite _closedIcon;

		[SerializeField]
		private Sprite _openIcon;

		[SerializeField]
		private int _defaultTimesToGuaranteedItem;

		[SerializeField]
		private RarityType _rarityOfGuaranteedItem;

		[Header("Purchase Data")]
		[SerializeField]
		private PurchaseData _primaryMultiplePurchase;

		[SerializeField]
		private PurchaseData _primaryOnePurchase;

		[SerializeField]
		private PurchaseData _secondaryPurchase;

		[SerializeField]
		private PurchaseData _adsPurchase;

		[Header("Rarity Probability")]
		[SerializeField]
		private List<RarityProbabilityItem> _rarityProbabilityItems;

		[Header("Rarity Amount")]
		[SerializeField]
		private Dictionary<RarityType, IntRangeValue> _itemRangeByRarity;

		[Header("Hardcoded Rewards")]
		[SerializeField]
		private List<UnitCardItemData> _hardcodedRewards;

		[Header("Guaranteed Item Priority")]
		[SerializeField]
		private List<UnitCardItemData> _prioritizedTenthItems;

		public string Guid => null;

		public string Title => null;

		public Sprite ClosedIcon => null;

		public Sprite OpenIcon => null;

		public int DefaultTimesToGuaranteedItem => 0;

		public RarityType RarityOfGuaranteedItem => default(RarityType);

		public PurchaseData PrimaryMultiplePurchase => null;

		public PurchaseData PrimaryOnePurchase => null;

		public PurchaseData SecondaryPurchase => null;

		public PurchaseData AdsPurchase => null;

		public List<RarityProbabilityItem> RarityProbabilityItems => null;

		public List<UnitCardItemData> HardcodedRewards => null;

		public List<UnitCardItemData> PrioritizedTenthItems => null;

		public RarityType GetRandomRarity()
		{
			return default(RarityType);
		}

		public int GetRandomAmount(RarityType rarityType)
		{
			return 0;
		}

		private void RecalculateProbability()
		{
		}
	}
}
