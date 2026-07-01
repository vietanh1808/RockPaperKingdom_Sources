using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public interface IPowerUpCellsProvider
	{
		List<BaseBuilding> GetTargetBuildings(PowerUpBuilding powerUpBuilding, BuildingSlotGrid grid);
	}
}
