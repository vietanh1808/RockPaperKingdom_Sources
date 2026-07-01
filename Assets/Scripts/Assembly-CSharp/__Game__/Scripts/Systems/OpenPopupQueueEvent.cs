using System;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class OpenPopupQueueEvent : IQueueEvent
	{
		private readonly UIBasePopup _popup;

		private readonly EventPriority _priority;

		public EventPriority Priority => default(EventPriority);

		public OpenPopupQueueEvent(UIBasePopup popup, EventPriority priority = EventPriority.NORMAL)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
