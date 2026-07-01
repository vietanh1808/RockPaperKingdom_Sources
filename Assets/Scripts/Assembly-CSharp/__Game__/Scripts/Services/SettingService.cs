using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Services
{
	public class SettingService
	{
		private const string SFX_KEY = "SfxActive";

		private const string MUSIC_KEY = "MusicActive";

		private const string VIBRATION_KEY = "VibrationActive";

		public bool IsSfxActive { get; private set; }

		public bool IsMusicActive { get; private set; }

		public bool IsVibrationActive { get; private set; }

		public event Action OnSfxActiveChanged
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

		public event Action OnMusicActiveChanged
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

		public void Initialize()
		{
		}

		public void SwitchSfxActivity()
		{
		}

		public void SwitchMusicActivity()
		{
		}

		public void SwitchHapticActivity()
		{
		}
	}
}
