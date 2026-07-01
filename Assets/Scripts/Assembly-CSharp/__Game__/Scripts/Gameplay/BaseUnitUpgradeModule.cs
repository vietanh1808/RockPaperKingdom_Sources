using Sirenix.OdinInspector;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseUnitUpgradeModule : SerializedScriptableObject
	{
		public abstract void Apply(SharedUnit sharedUnitData);

		public abstract string GetDescription();
	}
}
