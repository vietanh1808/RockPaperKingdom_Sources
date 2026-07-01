using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class TalentPriceSettings
	{
		[Header("Primary Currency")]
		[SerializeField]
		private InventoryItemData _currencyItemData;

		[SerializeField]
		private List<int> _priceTiers;

		[SerializeField]
		private int _tierIncrement;

		[SerializeField]
		private int _drawsPerTier;

		[Header("Secondary Currency")]
		[SerializeField]
		private InventoryItemData _secondaryCurrencyItemData;

		[SerializeField]
		private List<int> _secondaryPriceTiers;

		[SerializeField]
		private int _secondaryTierIncrement;

		[SerializeField]
		private int _secondaryDrawsPerTier;

		public InventoryItemData CurrencyItemData => null;

		public InventoryItemData SecondaryCurrencyItemData => null;

		public int GetPrice(int totalDrawCount)
		{
			return 0;
		}

		public int GetSecondaryPrice(int totalDrawCount)
		{
			return 0;
		}

		public PriceData GetPriceData(int totalDrawCount)
		{
			return null;
		}

		public PriceData GetSecondaryPriceData(int totalDrawCount)
		{
			return null;
		}

		public List<PriceData> GetAllPriceData(int totalDrawCount)
		{
			return null;
		}

		private static int GetTieredPrice(int totalDrawCount, List<int> tiers, int increment, int drawsPerTier)
		{
			return 0;
		}
	}
}
