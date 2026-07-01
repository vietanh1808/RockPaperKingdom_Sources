using System;

namespace __Game__.Scripts.Systems
{
	public class OpenUnitCardUnlockQueueEvent : IQueueEvent
	{
		private readonly UIUnitCardUnlockPopup _popup;

		private readonly UnitCardItemData _unitCardItemData;

		private readonly Action<string> _onClosed;

		public EventPriority Priority => default(EventPriority);

		public OpenUnitCardUnlockQueueEvent(UIUnitCardUnlockPopup popup, UnitCardItemData unitCardItemData, Action<string> onClosed)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
