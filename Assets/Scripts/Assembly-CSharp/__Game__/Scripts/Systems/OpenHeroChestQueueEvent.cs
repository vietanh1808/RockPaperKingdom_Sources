using System;

namespace __Game__.Scripts.Systems
{
	public class OpenHeroChestQueueEvent : IQueueEvent
	{
		private readonly UIRewardChest _uiRewardChest;

		private readonly ChestDataAmount _chestDataAmount;

		public OpenHeroChestQueueEvent(UIRewardChest uiRewardChest, ChestDataAmount chestDataAmount)
		{
		}

		public void Execute(Action onComplete)
		{
		}
	}
}
