using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseCollectibleCollection<T> : SerializedScriptableObject where T : BaseCollectibleItemData
	{
		[SerializeField]
		private string _folderPath;

		[SerializeField]
		private Dictionary<string, T> _items;

		[SerializeField]
		private Dictionary<RarityType, List<T>> _itemsByRarity;

		public Dictionary<string, T> Items => null;

		public List<T> GetItemsByRarity(RarityType rarityType)
		{
			return null;
		}
	}
}
