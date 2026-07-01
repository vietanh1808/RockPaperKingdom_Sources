using System.Collections.Generic;

namespace __Game__.Scripts.Services.ABTest
{
	public class ABTestService
	{
		private Dictionary<string, string> _remoteConfigCache;

		private readonly HashSet<string> _debugOverriddenKeys;

		public Dictionary<string, string> RemoteConfigCache => null;

		public bool IsLoaded { get; private set; }

		public void LoadData(Dictionary<string, string> remoteConfigCache)
		{
		}

		public void Initialize()
		{
		}

		public string GetVariant(string key, string defaultValue)
		{
			return null;
		}

		public void OverrideVariant(string key, string value)
		{
		}

		private void OnRemoteConfigsUpdated()
		{
		}

		private void ApplyRemoteConfig()
		{
		}
	}
}
