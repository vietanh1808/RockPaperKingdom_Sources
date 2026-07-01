using Sirenix.OdinInspector;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseBuildingUpgradeModule : SerializedScriptableObject
	{
		public abstract void Apply(BuildingRuntime buildingRuntime);

		public abstract string GetDescription();

		public abstract string GetShortDescription(BuildingRuntime buildingRuntime);

		public abstract string GetLongDescription(BuildingRuntime buildingRuntime);
	}
}
