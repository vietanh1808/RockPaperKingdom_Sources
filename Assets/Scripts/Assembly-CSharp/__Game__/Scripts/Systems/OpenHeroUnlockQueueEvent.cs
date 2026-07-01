using System;

namespace __Game__.Scripts.Systems
{
	public class OpenHeroUnlockQueueEvent : IQueueEvent
	{
		private readonly UIHeroUnlockPopup _popup;

		private readonly HeroItemData _heroItemData;

		private readonly Action<string> _onClosed;

		public EventPriority Priority => default(EventPriority);

		public OpenHeroUnlockQueueEvent(UIHeroUnlockPopup popup, HeroItemData heroItemData, Action<string> onClosed)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
