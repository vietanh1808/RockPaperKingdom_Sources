using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.Systems.DailyStreakQuest
{
	[CreateAssetMenu(fileName = "DailyStreakDayData", menuName = "TapHub/LiveOps/Daily Streak Day Data")]
	public class DailyStreakDayData : ScriptableObject
	{
		[SerializeField]
		private AssetModuleHolder<BaseMetaQuestData> _questHolder;

		public List<BaseMetaQuestData> Quests => null;

		private void OnEnable()
		{
		}
	}
}
