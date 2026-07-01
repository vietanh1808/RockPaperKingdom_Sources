using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseGameplayUpgrade : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private string _name;

		[Multiline]
		[SerializeField]
		private string _description;

		[TextArea]
		[SerializeField]
		private string _hint;

		[SerializeField]
		private int _maxUpgradesAmount;

		[SerializeField]
		private float _weight;

		[SerializeField]
		private BaseGameplayUpgrade[] _addUpgrades;

		[SerializeField]
		private BaseGameplayUpgrade[] _removeUpgrades;

		public string Guid => null;

		public string Name => null;

		public Sprite Icon => null;

		public int MaxUpgradesAmount => 0;

		public float Weight => 0f;

		public BaseGameplayUpgrade[] AddUpgrades => null;

		public BaseGameplayUpgrade[] RemoveUpgrades => null;

		public string Hint => null;

		public string Description => null;

		public abstract void Apply(GameplayUpgradesSystem gameplayUpgradesSystem);

		public virtual bool CanBeUsed(GameplayUpgradesSystem gameplayUpgradesSystem)
		{
			return false;
		}

		public virtual string[] GetDescription()
		{
			return null;
		}
	}
}
