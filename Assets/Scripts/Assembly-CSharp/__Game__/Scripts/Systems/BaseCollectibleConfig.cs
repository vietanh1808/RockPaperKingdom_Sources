using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseCollectibleConfig<T> : ScriptableObject where T : BaseCollectibleItemData
	{
		[SerializeField]
		private BaseCollectibleCollection<T> _collection;

		[SerializeField]
		private CollectibleLevelUpCollection _levelUpCollection;

		public BaseCollectibleCollection<T> Collection => null;

		public CollectibleLevelUpCollection LevelUp => null;
	}
}
