using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_Rarity", menuName = "TapHub/Configs/Rarity Config")]
	public class RarityConfig : SerializedScriptableObject
	{
		[SerializeField]
		private Dictionary<RarityType, RarityData> _rarity;

		[SerializeField]
		private RarityType _lastType;

		public bool IsLastType(RarityType rarityType)
		{
			return false;
		}

		public RarityData GetRarityData(RarityType rarityType)
		{
			return null;
		}
	}
}
