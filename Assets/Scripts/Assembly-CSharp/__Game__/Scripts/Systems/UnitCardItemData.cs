using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "ItemData_UnitCard", menuName = "TapHub/Collectible/UnitCard/UnitCard Item Data")]
	public class UnitCardItemData : BaseCollectibleItemData
	{
		[Header("Unit Stats")]
		[SerializeField]
		private List<UpgradableUnitStatData> _upgradeUnitStats;

		[Header("Upgrade")]
		[SerializeField]
		private AddBuildingUpgrade _addBuildingUpgrade;

		[Header("Flags")]
		[SerializeField]
		private bool _isFake;

		public BuildingType BuildingType => default(BuildingType);

		public AddBuildingUpgrade AddBuildingUpgrade => null;

		public bool IsFake => false;

		public Dictionary<UnitStatType, float> GetUnitStats(int level)
		{
			return null;
		}

		public Dictionary<UnitStatType, float> GetTowerStats(int level)
		{
			return null;
		}

		public Dictionary<UnitStatType, float> GetUnitMultipliers(int level)
		{
			return null;
		}

		private Dictionary<UnitStatType, float> GetBaseUnitStats()
		{
			return null;
		}

		private Dictionary<UnitStatType, float> GetBaseTowerStats()
		{
			return null;
		}
	}
}
