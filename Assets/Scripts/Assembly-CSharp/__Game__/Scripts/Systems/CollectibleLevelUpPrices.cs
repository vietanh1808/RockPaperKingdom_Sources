using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "CollectibleLevelUpPrices", menuName = "TapHub/Collectible/Level Up/Level Up Prices")]
	public class CollectibleLevelUpPrices : ScriptableObject
	{
		[SerializeField]
		private List<CollectibleLevelUpPrice> _priceByLevel;

		public int Count => 0;

		public CollectibleLevelUpPrice GetPrice(int level)
		{
			return null;
		}
	}
}
