using System;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class MenuFeatureUnlockPresenter : IDisposable
	{
		private readonly UIMenuSceneNavigation _uiMenuSceneNavigation;

		private readonly FeatureUnlockSystem _featureUnlockSystem;

		public MenuFeatureUnlockPresenter(UIMenuSceneNavigation uiMenuSceneNavigation, FeatureUnlockSystem featureUnlockSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnPendingUnlockFeatureAdded(FeatureItem featureItem)
		{
		}
	}
}
