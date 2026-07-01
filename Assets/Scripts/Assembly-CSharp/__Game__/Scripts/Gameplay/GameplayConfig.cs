using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_Gameplay", menuName = "TapHub/Configs/Gameplay Config")]
	public class GameplayConfig : ScriptableObject
	{
		[Header("Currency")]
		[SerializeField]
		private InventoryItemData _gameplayCurrencyItem;

		[SerializeField]
		private int _playGameCost;

		[Header("Mystery Shop Card")]
		[SerializeField]
		private InventoryItemData _mysteryShopCardItem;

		[Header("Card Sell")]
		[SerializeField]
		private int _cardSellPrice;

		public InventoryItemData GameplayCurrencyItem => null;

		public int PlayGameCost => 0;

		public InventoryItemData MysteryShopCardItem => null;

		public int CardSellPrice => 0;
	}
}
