using System;

namespace __Game__.Scripts.Systems
{
	public class OpenCollectibleUnlockQueueEvent : IQueueEvent
	{
		private readonly UICollectibleItemUnlockPopup _popup;

		private readonly BaseCollectibleItemData _itemData;

		private readonly Action<string> _onClosed;

		public OpenCollectibleUnlockQueueEvent(UICollectibleItemUnlockPopup popup, BaseCollectibleItemData itemData, Action<string> onClosed)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
