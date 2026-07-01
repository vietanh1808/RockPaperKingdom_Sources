using System;

namespace __Game__.Scripts.Systems
{
	public class StartTutorialQueueEvent : IQueueEvent
	{
		private readonly UIBaseMenuTutorial _menuTutorial;

		public StartTutorialQueueEvent(UIBaseMenuTutorial menuTutorial)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
