using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class BaseCollectibleNewAlertSystem<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		private readonly BaseCollectibleSystem<TItem, TItemData> _collectibleSystem;

		private int _newCount;

		private bool _alertNew;

		public bool AlertNew
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnAlertNewChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected BaseCollectibleNewAlertSystem(BaseCollectibleSystem<TItem, TItemData> collectibleSystem)
		{
		}

		public void Initialize()
		{
		}

		private void OnItemUnlocked(TItem item)
		{
		}

		private void SubscribeToItem(BaseCollectibleItem<TItemData> item)
		{
		}

		private void OnIsNewChangedHandler(bool isNew)
		{
		}
	}
}
