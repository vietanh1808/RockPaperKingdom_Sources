using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.UI
{
	public class UIMetaQuestProgressItem : MonoBehaviour
	{
		[Header("Description")]
		[SerializeField]
		private TMP_Text _descriptionText;

		[Header("Reward")]
		[SerializeField]
		private Image _rewardIcon;

		[Header("Status")]
		[SerializeField]
		private Image _completedBackgroundGlow;

		[SerializeField]
		private GameObject _alert;

		[Header("Button")]
		[SerializeField]
		private UIButtonClick _claimButton;

		private MetaQuestSystem _metaQuestSystem;

		private UIRewardFloating _uiRewardFloating;

		private BaseMetaQuestProcessor _activeProcessor;

		[Inject]
		private void Inject(MetaQuestSystem metaQuestSystem, UIRewardFloating uiRewardFloating)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnActiveProcessorChanged(BaseMetaQuestProcessor processor)
		{
		}

		private void SubscribeToProcessor()
		{
		}

		private void UnsubscribeFromProcessor()
		{
		}

		private void OnCompleted()
		{
		}

		private void UpdateDisplay()
		{
		}

		private void UpdateStatus(bool isCompleted)
		{
		}

		private void OnClaimButtonClicked()
		{
		}
	}
}
