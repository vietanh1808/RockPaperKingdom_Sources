namespace __Game__.Scripts.Systems
{
	public class HeroSelectionFeatureUnlockProcessor
	{
		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly HeroConfig _heroConfig;

		private readonly HeroSystem _heroSystem;

		private FeatureItem _heroFeatureItem;

		private FeatureItem _heroSelectionFeatureItem;

		private HeroItem _triggerHeroItem;

		public HeroSelectionFeatureUnlockProcessor(FeatureUnlockSystem featureUnlockSystem, FeatureUnlockConfig featureUnlockConfig, HeroConfig heroConfig, HeroSystem heroSystem)
		{
		}

		private void InitializeFeatureUnlock()
		{
		}

		private void OnHeroFeatureItemStatusChanged(FeatureItem featureItem)
		{
		}

		private void OnTriggerHeroUnlocked()
		{
		}

		private void CheckSelectionReadiness()
		{
		}

		private void CheckFeatureItemForUnsubscribe()
		{
		}
	}
}
