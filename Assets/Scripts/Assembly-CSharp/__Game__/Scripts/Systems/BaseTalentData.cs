using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseTalentData : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private RarityType _rarityType;

		public string Guid => null;

		public Sprite Icon => null;

		public RarityType RarityType => default(RarityType);

		public abstract int MaxLevelIndex { get; }

		public abstract string GetDescription(int levelIndex);
	}
}
