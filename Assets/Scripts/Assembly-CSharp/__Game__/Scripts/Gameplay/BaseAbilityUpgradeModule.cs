using Sirenix.OdinInspector;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseAbilityUpgradeModule : SerializedScriptableObject
	{
		public abstract void Apply(SharedAbility sharedAbility);

		public abstract string GetDescription();
	}
}
