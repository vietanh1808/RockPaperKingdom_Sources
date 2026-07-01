using System;

namespace __Game__.Scripts.Gameplay.Waves
{
	public interface IRoundEventProvider
	{
		event Action OnRoundStarted;
	}
}
