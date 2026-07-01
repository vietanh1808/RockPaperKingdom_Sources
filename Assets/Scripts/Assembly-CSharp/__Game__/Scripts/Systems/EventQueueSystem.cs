using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class EventQueueSystem
	{
		private readonly LinkedList<IQueueEvent> _eventQueue;

		private int _runningEvents;

		public void Enqueue(IQueueEvent queueEvent)
		{
		}

		public void EnqueueFront(IQueueEvent queueEvent)
		{
		}

		private void InsertByPriority(IQueueEvent queueEvent)
		{
		}

		public void ExecuteImmediate(IQueueEvent queueEvent)
		{
		}

		private void ProcessNext()
		{
		}

		private void EventCompleted()
		{
		}
	}
}
