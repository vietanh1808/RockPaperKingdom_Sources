using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.CardPurchase
{
	[CreateAssetMenu(fileName = "Config_CardPurchaseConfig", menuName = "TapHub/Configs/Card Purchase Config")]
	public class CardPurchaseConfig : ScriptableObject
	{
		[SerializeField]
		private InventoryItemData _priceItemData;

		[SerializeField]
		private int _initialPrice;

		[SerializeField]
		private int _priceIncrement;

		public InventoryItemData PriceItemData => null;

		public int InitialPrice => 0;

		public int PriceIncrement => 0;
	}
}
