using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Feature", menuName = "TapHub/Features/Feature Item Data")]
	public class FeatureItemData : ScriptableObject
	{
		[SerializeField]
		private string _guid;

		[Multiline]
		[SerializeField]
		private string _title;

		[SerializeField]
		private Sprite _icon;

		[Header("Feature Unlock")]
		[SerializeField]
		private FeatureUnlockType _featureUnlockType;

		[SerializeField]
		private bool _showPopup;

		[SerializeField]
		private bool _forceEventQueueInFront;

		[SerializeField]
		private int _levelIndex;

		[SerializeField]
		private int _stageIndex;

		public string Guid => null;

		public string Title => null;

		public Sprite Icon => null;

		public FeatureUnlockType FeatureUnlockType => default(FeatureUnlockType);

		public bool ShowPopup => false;

		public bool ForceEventQueueInFront => false;

		public int LevelIndex => 0;

		public int StageIndex => 0;

		public string UnlockRequirementMessage => null;

		private bool ShowPopupSetting => false;

		private bool ShowForceEventQueueInFront => false;

		private bool IsLevelUnlock => false;

		private bool IsStageUnlock => false;
	}
}
