using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems.MetaQuest
{
	[CreateAssetMenu(fileName = "Config_MetaQuest", menuName = "TapHub/Configs/Meta Quest Config")]
	public class MetaQuestConfig : ScriptableObject
	{
		[SerializeField]
		private int _requiredLevelIndex;

		[SerializeField]
		private AssetModuleHolder<BaseMetaQuestData> _quests;

		public int RequiredLevelIndex => 0;

		public AssetModuleHolder<BaseMetaQuestData> Quests => null;

		public BaseMetaQuestData GetQuestByGuid(string guid)
		{
			return null;
		}

		private void OnInspectorInit()
		{
		}
	}
}
