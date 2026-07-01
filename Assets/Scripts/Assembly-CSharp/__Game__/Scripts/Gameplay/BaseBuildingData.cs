using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseBuildingData : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private AddBuildingUpgrade _addBuildingUpgrade;

		[SerializeField]
		private bool _isTargetable;

		[SerializeField]
		private ModularBuildingLevelUp _level2LevelUp;

		[SerializeField]
		private ModularBuildingLevelUp _level3LevelUp;

		public string Guid => null;

		public string Name => null;

		public Sprite Icon => null;

		public abstract BaseBuilding Prefab { get; }

		public abstract BuildingType BuildingType { get; }

		public bool IsTargetable => false;

		public ModularBuildingLevelUp Level2LevelUp => null;

		public ModularBuildingLevelUp Level3LevelUp => null;

		public bool IsUpgradeable => false;

		public virtual UniqueBonusHolder UniqueBonus => null;

		public virtual bool CanAffectBuilding(BaseBuilding building)
		{
			return false;
		}
	}
}
