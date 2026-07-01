using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class PowerUpBuilding : BaseBuilding
	{
		[Header("Sounds")]
		[SerializeField]
		private SoundData _upgradeSound;

		private PowerUpCellsProviderFactory _cellsProviderFactory;

		private IPowerUpCellsProvider _cellsProvider;

		public PowerUpBuildingData PowerUpBuildingData { get; private set; }

		[Inject]
		public void Construct(PowerUpCellsProviderFactory cellsProviderFactory)
		{
		}

		public void Construct(PowerUpBuildingData buildingData, BuildingRuntime building)
		{
		}

		public override void UpdateSkinForPlacement(BaseBuildingData selectedBuildingData, bool isInteractable, int emptyNeighborCount)
		{
		}

		public void ApplyUpgradesToNeighbors(BuildingSlotGrid grid)
		{
		}

		private void PlayVisualEffects()
		{
		}

		private void ApplyUpgradesToAllBuildings(List<BaseBuilding> buildings)
		{
		}

		private void ApplyUpgradesToBuilding(BuildingRuntime buildingRuntime)
		{
		}
	}
}
