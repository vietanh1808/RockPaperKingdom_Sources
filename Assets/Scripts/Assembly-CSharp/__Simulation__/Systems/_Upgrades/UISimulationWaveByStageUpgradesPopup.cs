using TMPro;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationWaveByStageUpgradesPopup : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _upgradesContainer;

		[SerializeField]
		private TMP_Text _titleText;

		[SerializeField]
		private UISimulationUpgradeRecordItem _uiSimulationWaveByStageStrategyTitlePrefab;

		public void Show(StageLog stageLog, string title, int currentIndex)
		{
		}

		public void Hide()
		{
		}
	}
}
