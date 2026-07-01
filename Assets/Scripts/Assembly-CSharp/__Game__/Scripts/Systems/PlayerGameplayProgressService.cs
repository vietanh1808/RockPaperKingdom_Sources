using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class PlayerGameplayProgressService
	{
		public bool IsGameplayCoinsReceivedOnce { get; private set; }

		public event Action OnRpsAvailabilityChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void LoadData(bool isGameplayCoinsReceivedOnce)
		{
		}

		public void MarkRpsAvailable()
		{
		}
	}
}
