using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "GameplayDebugStrategySettings_", menuName = "TapHub/Debug/Strategy Settings")]
	public class GameplaySimulationSettings : ScriptableObject
	{
		[SerializeField]
		private Color _color;

		[Header("Upgrade Select")]
		[SerializeField]
		private List<BaseGameplayUpgrade> _upgradesForced;

		[SerializeField]
		private List<UnitData> _unitsPriority;

		[SerializeField]
		private List<BaseGameplayUpgrade> _upgradesPriority;

		[Header("Boss Chest Upgrade Select")]
		[SerializeField]
		private List<BaseGameplayUpgrade> _bossChestUpgradesForced;

		[SerializeField]
		private List<BaseGameplayUpgrade> _bossChestUpgradesPriority;

		[Header("Building Placement")]
		[SerializeField]
		private BuildingPlacementConfig _buildingPlacementConfig;

		[Header("Random Seed")]
		[SerializeField]
		private bool _useOverrideSeed;

		[SerializeField]
		private int _seed;

		public string Title => null;

		public Color Color => default(Color);

		public List<UnitData> UnitsPriority => null;

		public List<BaseGameplayUpgrade> UpgradesPriority => null;

		public List<BaseGameplayUpgrade> UpgradesForced => null;

		public bool UseOverrideSeed => false;

		public int Seed => 0;

		public bool UseBuildingPlacementSimulation => false;

		public BuildingPlacementConfig BuildingPlacementConfig => null;

		public List<BaseGameplayUpgrade> BossChestUpgradesForced => null;

		public List<BaseGameplayUpgrade> BossChestUpgradesPriority => null;

		private void RandomizeColor()
		{
		}
	}
}
