using TMPro;
using UnityEngine;

namespace __Simulation__.Systems
{
	public class UISimulationGraphElement : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _stageText;

		[SerializeField]
		private TMP_Text _durationText;

		[SerializeField]
		private TMP_Text _dayText;

		[SerializeField]
		private TMP_Text _indexText;

		[Header("Time Shifts")]
		[SerializeField]
		private GameObject _dayShift;

		[SerializeField]
		private GameObject _sessionShift;

		[Header("Colors")]
		[SerializeField]
		private Color _victoryColor;

		[SerializeField]
		private Color _defeatColor;

		public void Construct(int index, SimulationSnapshot simulationSnapshot)
		{
		}

		public void DisplaySessionShift()
		{
		}

		public void DisplayDayShift()
		{
		}
	}
}
