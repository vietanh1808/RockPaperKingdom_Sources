using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_PlayerStatInfo", menuName = "TapHub/Stats/Stats Info Collection")]
	public class PlayerStatInfoCollection : SerializedScriptableObject
	{
		[SerializeField]
		private Dictionary<PlayerStatType, StatInfo> _statDataDictionary;

		public List<PlayerStatType> StatTypes => null;

		public StatInfo GetStatInfo(PlayerStatType playerStatType)
		{
			return null;
		}
	}
}
