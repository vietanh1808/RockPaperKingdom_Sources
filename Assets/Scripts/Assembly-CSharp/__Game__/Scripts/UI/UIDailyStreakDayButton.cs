using TMPro;
using UnityEngine;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.UI
{
	public class UIDailyStreakDayButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _button;

		[SerializeField]
		private TMP_Text _dayLabel;

		[SerializeField]
		private GameObject _lockedState;

		[SerializeField]
		private GameObject _selectedState;

		[SerializeField]
		private GameObject _alertMark;

		private UIDailyStreakQuestPopup _popup;

		private DailyStreakQuestSystem _system;

		private int _dayIndex;

		private bool _isUnlocked;

		public void Initialize(UIDailyStreakQuestPopup popup, int dayIndex, DailyStreakQuestSystem system)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateState(bool isUnlocked, bool isSelected)
		{
		}

		public void RefreshAlert()
		{
		}

		private void OnClicked()
		{
		}
	}
}
