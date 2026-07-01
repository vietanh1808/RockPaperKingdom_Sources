using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.UI
{
	public class UIDailyStreakQuestPopup : UIBasePopup
	{
		[SerializeField]
		private TMP_Text _timerText;

		[SerializeField]
		private List<UIDailyStreakDayButton> _dayButtons;

		[SerializeField]
		private UIDailyStreakQuestItem _questItemPrefab;

		[SerializeField]
		private Transform _questListContainer;

		[SerializeField]
		private ScrollRect _questScrollRect;

		[SerializeField]
		private UIDailyStreakRewardsBar _rewardsBar;

		private DiContainer _diContainer;

		private DailyStreakQuestSystem _system;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private readonly List<UIDailyStreakQuestItem> _questItems;

		private int _selectedDayIndex;

		[Inject]
		private void Inject(DiContainer diContainer, DailyStreakQuestSystem system, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		private void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void SelectDay(int dayIndex)
		{
		}

		private void Update()
		{
		}

		private void InitializeDayButtons()
		{
		}

		private void UpdateTimer()
		{
		}

		private void RefreshDayButtons()
		{
		}

		private void RebuildQuestList()
		{
		}

		private void SortQuestItems()
		{
		}

		private void DestroyQuestItems()
		{
		}

		private void RefreshCurrentDay()
		{
		}

		private void RefreshDayButtonAlerts()
		{
		}
	}
}
