using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingPlacementStateTracker
	{
		private readonly BuildingPlacementHand _placementHand;

		private BuildingSlot _currentSlot;

		private BuildingInfoStatus _currentState;

		public BuildingSlot CurrentSlot => null;

		public BuildingInfoStatus CurrentStatus => default(BuildingInfoStatus);

		public event Action<BuildingInfoStatus> OnPlacementStateChanged
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

		public BuildingPlacementStateTracker(BuildingPlacementHand placementHand)
		{
		}

		public void NotifySlotEntered(BuildingSlot slot)
		{
		}

		public void NotifySlotExited(BuildingSlot slot)
		{
		}

		private void OnSelectedBuildingChanged()
		{
		}

		private void UpdatePlacementState()
		{
		}

		private BuildingInfoStatus CalculateState()
		{
			return default(BuildingInfoStatus);
		}
	}
}
