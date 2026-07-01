namespace __Game__.Scripts.Systems
{
	public class HeroUpgradeFeatureUnlockProcessor
	{
		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly FeatureUnlockConfig _featureUnlockConfig;

		private readonly HeroUpgradeAlertSystem _heroUpgradeAlertSystem;

		private FeatureItem _heroFeatureItem;

		private FeatureItem _heroUpgradeFeatureItem;

		public HeroUpgradeFeatureUnlockProcessor(FeatureUnlockSystem featureUnlockSystem, FeatureUnlockConfig featureUnlockConfig, HeroUpgradeAlertSystem heroUpgradeAlertSystem)
		{
		}

		private void InitializeFeatureUnlock()
		{
		}

		private void OnHeroFeatureItemStatusChanged(FeatureItem featureItem)
		{
		}

		private void CheckUpgradeReadiness()
		{
		}

		private void CheckFeatureItemForUnsubscribe()
		{
		}
	}
}
