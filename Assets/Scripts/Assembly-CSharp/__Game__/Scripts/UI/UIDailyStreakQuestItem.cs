using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.UI
{
	public class UIDailyStreakQuestItem : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _descriptionText;

		[SerializeField]
		private Transform _rewardsContainer;

		[SerializeField]
		private UIButtonClick _claimButton;

		[SerializeField]
		private GameObject _completedState;

		[SerializeField]
		private GameObject _claimableState;

		private UIRewardsFactory _rewardsFactory;

		private UIRewardFloating _uiRewardFloating;

		private DailyStreakQuestSystem _system;

		private BaseMetaQuestData _questData;

		private BaseMetaQuestProcessor _processor;

		private int _cachedTargetValue;

		public int SortOrder => 0;

		[Inject]
		private void Inject(UIRewardsFactory rewardsFactory, UIRewardFloating uiRewardFloating)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Bind(BaseMetaQuestData questData, DailyStreakQuestSystem system)
		{
		}

		private void SubscribeToProcessor()
		{
		}

		private void UnsubscribeFromProcessor()
		{
		}

		private void OnProgressChanged(float progress)
		{
		}

		private void OnCompleted()
		{
		}

		private void BuildRewards()
		{
		}

		public void RefreshDisplay()
		{
		}

		private void UpdateDisplay()
		{
		}

		private string FormatDescription(bool isCompleted)
		{
			return null;
		}

		private void OnClaimClicked()
		{
		}

		private RectTransform GetFirstRewardRect()
		{
			return null;
		}
	}
}
