using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRewardChestAnimationMultiple : MonoBehaviour
	{
		private const float NEXT_DRAW_DELAY = 0.6f;

		[Header("Buttons")]
		[SerializeField]
		private UIButtonClick _skipButton;

		[SerializeField]
		private UIButtonClick _nextButton;

		[Header("Views")]
		[SerializeField]
		private UIChestResultView _uiChestResultView;

		[Header("Containers")]
		[SerializeField]
		private RectTransform _moreTransform;

		[SerializeField]
		private RectTransform _continueTransform;

		[SerializeField]
		private RectTransform _resultTransform;

		[Header("Animation")]
		[SerializeField]
		private UIRewardChestOpeningAnimation _uiRewardChestOpeningAnimation;

		private List<ChestRewardDisplayItem> _displayItems;

		private int _itemCount;

		private Tween _autoAdvanceTween;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OpenChest(List<ChestRewardDisplayItem> displayItems)
		{
		}

		private void StartAnimation()
		{
		}

		private void ResetView()
		{
		}

		private void NextDrawCheck()
		{
		}

		private void ShowAllReceivedItems()
		{
		}

		private void ShowTapToContinue()
		{
		}

		private void SkipButtonClicked()
		{
		}

		private void NextButtonClicked()
		{
		}
	}
}
