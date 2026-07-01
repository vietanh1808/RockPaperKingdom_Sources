using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Arena
{
	[CreateAssetMenu(fileName = "ArenaEnemyStrategy_", menuName = "TapHub/Arena/Arena Enemy Strategy")]
	public class ArenaEnemyStrategyData : ScriptableObject
	{
		[Header("Available Cards")]
		[SerializeField]
		private List<AddBuildingUpgrade> _availableCards;

		[Header("Upgrade Select")]
		[SerializeField]
		private List<BaseGameplayUpgrade> _upgradesForced;

		[SerializeField]
		private List<BaseGameplayUpgrade> _upgradesPriority;

		[Header("Building Placement")]
		[SerializeField]
		private BuildingPlacementConfig _buildingPlacementConfig;

		public List<AddBuildingUpgrade> AvailableCards => null;

		public List<BaseGameplayUpgrade> UpgradesForced => null;

		public List<BaseGameplayUpgrade> UpgradesPriority => null;

		public BuildingPlacementConfig BuildingPlacementConfig => null;
	}
}
