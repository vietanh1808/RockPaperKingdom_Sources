using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class ChestItem
	{
		private int _claimCounter;

		public int ClaimCounter
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action OnClaimCounterChanged
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

		public ChestItem(int claimCounter)
		{
		}
	}
}
