using System;

namespace __Game__.Scripts.Systems
{
	public class OpenFeatureUnlockQueueEvent : IQueueEvent
	{
		private readonly UIFeaturesUnlockPopup _popup;

		private readonly FeatureItem _featureItem;

		public EventPriority Priority => default(EventPriority);

		public OpenFeatureUnlockQueueEvent(UIFeaturesUnlockPopup popup, FeatureItem featureItem)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
