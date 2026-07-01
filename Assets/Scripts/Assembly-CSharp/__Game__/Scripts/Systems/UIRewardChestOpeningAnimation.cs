using System;
using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class UIRewardChestOpeningAnimation : MonoBehaviour
	{
		private const float FLIP_DURATION = 0.2f;

		private const float FLIP_DELAY = 0.3f;

		[SerializeField]
		private UIUnitCardRewardElement _uiRewardElement;

		[SerializeField]
		private RectTransform _rewardElementTransform;

		[Header("Containers")]
		[SerializeField]
		private RectTransform _closedChestContainer;

		[SerializeField]
		private RectTransform _openChestContainer;

		[SerializeField]
		private RectTransform _openChestTransform;

		[Header("Audio")]
		[SerializeField]
		private SoundData _flipSfx;

		private Action _onCompleted;

		private Tween _delayForCompleted;

		private ChestRewardItem _currentRewardItem;

		private bool _showAsNewCard;

		private void OnDisable()
		{
		}

		public void OpenChest(ChestRewardItem rewardItem, bool showAsNewCard, Action onCompleted)
		{
		}

		public void ResetView()
		{
		}

		private void ShowOpeningChest()
		{
		}

		private void ShowReceivedItem()
		{
		}

		private void OnRewardItemShown()
		{
		}

		private void PlayFlipAnimation()
		{
		}

		private void OnFlipHalfway()
		{
		}

		private void InvokeOnCompleted()
		{
		}
	}
}
