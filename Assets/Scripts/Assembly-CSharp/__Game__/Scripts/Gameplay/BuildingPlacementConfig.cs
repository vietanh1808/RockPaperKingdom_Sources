using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_BuildingPlacement", menuName = "TapHub/Debug/Building Placement Config")]
	public class BuildingPlacementConfig : SerializedScriptableObject
	{
		[SerializeField]
		private BuildingPlacementRules _defaultRules;

		[Header("Per-Building Rules")]
		[SerializeField]
		private Dictionary<AddBuildingUpgrade, BuildingPlacementRules> _buildingRules;

		[Header("Per-BuildingType Fallback Rules")]
		[SerializeField]
		private Dictionary<BuildingType, BuildingPlacementRules> _buildingTypeRules;

		public BuildingPlacementRules DefaultRules => null;

		public BuildingPlacementRules GetRules(AddBuildingUpgrade upgrade)
		{
			return null;
		}
	}
}
