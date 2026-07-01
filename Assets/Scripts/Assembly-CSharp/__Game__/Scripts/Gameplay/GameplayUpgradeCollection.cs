using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Collection_GameplayUpgrade", menuName = "TapHub/Ability/GameplayUpgradeCollection")]
	public class GameplayUpgradeCollection : SerializedScriptableObject
	{
		[SerializeField]
		private List<BaseGameplayUpgrade> _collection;

		[SerializeField]
		private Dictionary<string, BaseGameplayUpgrade> _dataByGuid;

		public BaseGameplayUpgrade GetData(string guid)
		{
			return null;
		}
	}
}
