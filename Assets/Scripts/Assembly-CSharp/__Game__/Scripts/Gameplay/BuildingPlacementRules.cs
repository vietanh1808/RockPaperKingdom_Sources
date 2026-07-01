using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "BuildingPlacementRules_", menuName = "TapHub/Debug/Building Placement Rules")]
	public class BuildingPlacementRules : ScriptableObject
	{
		[Header("Neighbor Priority — Specific Buildings")]
		[SerializeField]
		private List<BaseBuildingData> _neighborPriority;

		[Header("Neighbor Priority — Building Type Fallback")]
		[SerializeField]
		private List<BuildingType> _buildingTypePriority;

		[Header("Neighbor Quantity")]
		[SerializeField]
		private NeighborQuantityPreference _neighborQuantityPreference;

		[Header("Placement")]
		[SerializeField]
		private PlacementPreference _placementPreference;

		[SerializeField]
		private int _minEmptySlotsForNewPlacement;

		public List<BaseBuildingData> NeighborPriority => null;

		public List<BuildingType> BuildingTypePriority => null;

		public NeighborQuantityPreference NeighborQuantityPreference => default(NeighborQuantityPreference);

		public PlacementPreference PlacementPreference => default(PlacementPreference);

		public int MinEmptySlotsForNewPlacement => 0;
	}
}
