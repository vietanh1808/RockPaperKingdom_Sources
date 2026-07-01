namespace __Game__.Scripts.Gameplay
{
	public class PowerUpCellsProviderFactory
	{
		private readonly AllCellsPowerUpProvider _allCellsProvider;

		private readonly SingleCellPowerUpProvider _singleCellProvider;

		public IPowerUpCellsProvider Get(PowerUpCellsProviderType providerType)
		{
			return null;
		}
	}
}
