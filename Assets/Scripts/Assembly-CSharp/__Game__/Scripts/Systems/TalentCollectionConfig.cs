using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_Talents", menuName = "TapHub/Talents/TalentCollectionConfig")]
	public class TalentCollectionConfig : SerializedScriptableObject
	{
		[SerializeField]
		private List<BaseTalentData> _collection;

		[SerializeField]
		private Dictionary<string, BaseTalentData> _dataByGuid;

		[SerializeField]
		private int _maxLevelIndex;

		[Header("Rarity Probability")]
		[SerializeField]
		private List<RarityProbabilityItem> _rarityProbabilityItems;

		[Header("Hardcoded Order")]
		[SerializeField]
		private List<BaseTalentData> _firstUnlockOrder;

		[Header("Price Data")]
		[SerializeField]
		private TalentPriceSettings _priceSettings;

		public int MaxLevelIndex => 0;

		public List<RarityProbabilityItem> RarityProbabilityItems => null;

		public List<BaseTalentData> FirstUnlockOrder => null;

		public TalentPriceSettings PriceSettings => null;

		public List<BaseTalentData> GetCollection()
		{
			return null;
		}
	}
}
