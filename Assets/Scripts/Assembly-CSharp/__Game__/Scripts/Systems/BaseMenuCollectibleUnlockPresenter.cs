using System;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseMenuCollectibleUnlockPresenter<TItem, TItemData> : IDisposable where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly BaseCollectibleSystem<TItem, TItemData> _collectibleSystem;

		protected BaseMenuCollectibleUnlockPresenter(BaseCollectibleSystem<TItem, TItemData> collectibleSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		protected abstract void ShowUnlockingItem(BaseCollectibleItemData collectibleItemData);

		protected void UnlockItem(string guid)
		{
		}
	}
}
