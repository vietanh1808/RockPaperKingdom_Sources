using System;

namespace __Game__.Scripts.Systems
{
	public class PlayerInstallTracker
	{
		public DateTime InstallDate { get; private set; }

		public string InstallVersion { get; private set; }

		public int DaysSinceInstall => 0;

		public void LoadData(DateTime installDate, string installVersion)
		{
		}

		public void Initialize()
		{
		}
	}
}
