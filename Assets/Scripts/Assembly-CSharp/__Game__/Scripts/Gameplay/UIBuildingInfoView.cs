using TMPro;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingInfoView : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _actionText;

		[SerializeField]
		private TextMeshProUGUI _statsText;

		private BuildingPlacementStateTracker _stateTracker;

		private BuildingInfoProvider _infoProvider;

		private BuildingPlacementHand _placementHand;

		private BuildingHoverController _hoverController;

		[Inject]
		public void Inject(BuildingPlacementStateTracker stateTracker, BuildingInfoProvider infoProvider, BuildingPlacementHand placementHand, BuildingHoverController hoverController)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnStateChanged(BuildingInfoStatus state)
		{
		}

		private void OnStateChanged()
		{
		}

		private void UpdateDisplay()
		{
		}

		private void UpdateHoveredBuildingDisplay(BaseBuilding building)
		{
		}

		private void UpdatePlacementDisplay()
		{
		}
	}
}
