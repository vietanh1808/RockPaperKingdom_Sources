using __Game__.Scripts.Systems;

namespace __Simulation__.SimulationModules
{
	public class SimulationModuleAvailableSystem
	{
		private readonly FeatureUnlockSystem _featureUnlockSystem;

		private readonly MenuTutorialSystem _menuTutorialSystem;

		public SimulationModuleAvailableSystem(FeatureUnlockSystem featureUnlockSystem, MenuTutorialSystem menuTutorialSystem)
		{
		}

		public bool IsAvailable(string featureGuid)
		{
			return false;
		}
	}
}
