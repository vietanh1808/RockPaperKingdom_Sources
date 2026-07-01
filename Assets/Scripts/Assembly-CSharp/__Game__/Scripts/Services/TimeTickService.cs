using System;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Services
{
	public class TimeTickService : ITickable
	{
		private float _timeAccumulator;

		public static event Action OnSecondTick
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

		public void Tick()
		{
		}
	}
}
