using Zenject;

namespace __Game__.Scripts.Services
{
	public class VibrationService
	{
		private readonly SettingService _settingService;

		public static VibrationService Instance { get; private set; }

		[Inject]
		public VibrationService(SettingService settingService)
		{
		}

		public void PlayLightImpact()
		{
		}

		public void PlayFailure()
		{
		}

		public void PlayWarning()
		{
		}
	}
}
