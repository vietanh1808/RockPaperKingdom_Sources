using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleSorter<TSystem, TItem, TItemData> where TSystem : BaseCollectibleSystem<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly TSystem _collectibleSystem;

		public UICollectibleSorter(TSystem collectibleSystem)
		{
		}

		public void Sort(Dictionary<TItem, UIBaseCollectibleInventoryElement<TItem, TItemData>> elements)
		{
		}
	}
}
