using System;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class HeroCardsTutorialProcessor : IDisposable
	{
		private const string TUTORIAL_SHOWN_KEY = "HeroCardsTutorialShown";

		private readonly MenuTutorialSystem _menuTutorialSystem;

		private readonly UIHeroControlPopup _heroControlPopup;

		private readonly string _tutorialGuid;

		public HeroCardsTutorialProcessor(MenuTutorialSystem menuTutorialSystem, UIMenuSceneNavigation menuSceneNavigation, FeatureUnlockConfig featureUnlockConfig)
		{
		}

		public void Dispose()
		{
		}

		private void OnCardsTabActivated()
		{
		}
	}
}
