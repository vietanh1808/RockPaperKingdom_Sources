using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_Stages", menuName = "TapHub/Collections/Stages")]
	public class StagesCollection : ScriptableObject
	{
		[SerializeField]
		private List<StageData> _stages;

		[SerializeField]
		private List<StageData> _loopedStages;

		[SerializeField]
		private List<StageData> _hardStages;

		[SerializeField]
		private List<StageData> _hardLoopedStages;

		[TextArea(10, 40)]
		[SerializeField]
		private string _csvOverview;

		[TextArea(10, 40)]
		[SerializeField]
		private string _csvNewUnitsOverview;

		public List<StageData> Stages => null;

		public List<StageData> LoopedStages => null;

		public bool HasLoopedStages => false;

		public List<StageData> HardStages => null;

		public List<StageData> HardLoopedStages => null;

		public bool HasHardLoopedStages => false;

		public StageData GetStageData(int index)
		{
			return null;
		}

		public StageData GetStageData(StageModeType modeType, int index)
		{
			return null;
		}

		public List<StageData> GetStages(StageModeType modeType)
		{
			return null;
		}

		public List<StageData> GetLoopedStages(StageModeType modeType)
		{
			return null;
		}

		public bool HasLoopedStagesForMode(StageModeType modeType)
		{
			return false;
		}
	}
}
