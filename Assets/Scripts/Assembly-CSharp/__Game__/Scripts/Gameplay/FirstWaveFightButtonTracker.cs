using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class FirstWaveFightButtonTracker : IDisposable
	{
		private readonly BuildingPlacementHand _placementHand;

		private readonly BuildingSlotGrid _slotGrid;

		private readonly BuildingRepository _buildingRepository;

		private readonly WaveSystem _waveSystem;

		private bool _canShowFightButton;

		public bool CanShowFightButton => false;

		public event Action OnCanShowFightButtonChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public FirstWaveFightButtonTracker(BuildingPlacementHand placementHand, BuildingSlotGrid slotGrid, BuildingRepository buildingRepository, WaveSystem waveSystem)
		{
		}

		public void Dispose()
		{
		}

		private void OnHandChanged(BuildingUpgradeRuntime _)
		{
		}

		private void OnBoardChanged(BaseBuilding _)
		{
		}

		private void OnEmptySlotsChanged(bool _)
		{
		}

		private void Recalculate()
		{
		}

		private void SetCanShowFightButton(bool value)
		{
		}

		private bool HasAnyPlaceableCard()
		{
			return false;
		}

		private bool CanPlaceCard(BuildingUpgradeRuntime upgrade)
		{
			return false;
		}

		private bool HasValidLevelUpTarget(LevelUpBuildingData levelUpData)
		{
			return false;
		}

		private bool HasUpgradeableBuilding(BaseBuildingData buildingData)
		{
			return false;
		}
	}
}
