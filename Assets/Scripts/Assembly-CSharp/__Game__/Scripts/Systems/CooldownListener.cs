using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class CooldownListener
	{
		private readonly string _guid;

		public TimeSpan Time { get; private set; }

		public bool IsActive { get; private set; }

		public event Action<bool> OnStatusChanged
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

		public event Action<TimeSpan> OnTimeChanged
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

		public CooldownListener(string guid)
		{
		}

		public string GetCooldownGuid()
		{
			return null;
		}

		public void UpdateCooldown(float seconds)
		{
		}

		public void SetCooldownStatus(bool isActive)
		{
		}
	}
}
