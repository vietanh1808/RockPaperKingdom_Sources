using TMPro;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingPlacementCardsCounter : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _cardsCountText;

		private BuildingPlacementHand _buildingPlacementHand;

		[Inject]
		public void Inject(BuildingPlacementHand buildingPlacementHand)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCardsChanged(BuildingUpgradeRuntime _)
		{
		}

		private void UpdateDisplay()
		{
		}
	}
}
