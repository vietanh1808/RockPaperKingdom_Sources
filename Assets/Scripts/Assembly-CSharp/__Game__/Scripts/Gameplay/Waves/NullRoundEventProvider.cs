using System;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class NullRoundEventProvider : IRoundEventProvider
	{
		public event Action OnRoundStarted
		{
			add
			{
			}
			remove
			{
			}
		}
	}
}
