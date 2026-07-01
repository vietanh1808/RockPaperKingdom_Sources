using System;

namespace __Game__.Scripts.Systems
{
	public interface IQueueEvent
	{
		EventPriority Priority => default(EventPriority);

		void Execute(Action onComplete);
	}
}
